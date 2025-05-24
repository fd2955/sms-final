using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Sms_Otomasyon_New
{
    public partial class bos : Form
    {
        private List<string> allContacts = new List<string>();
        public bos()
        {
            InitializeComponent();
        }
        private void LoadContacts()
        {
            if (File.Exists("kisiler.txt"))
            {
                string[] lines = File.ReadAllLines("kisiler.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split('-');
                    if (parts.Length == 2)
                    {
                        dgvContacts.Rows.Add(parts[0].Trim(), parts[1].Trim());
                        allContacts.Add(line); // Arama için listeye ekliyoruz
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
           private void LogYaz(string logMetni, bool basarili)
        {
            string durum = basarili ? "✅ Başarılı" : "❌ Başarısız";

            lstGecmisSonuc.AppendText($"{DateTime.Now:HH:mm:ss} - {durum} - {logMetni}{Environment.NewLine}");
            File.AppendAllText("sms_log.txt", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {durum} - {logMetni}{Environment.NewLine}");
        }

        
        private async void btnSend_Click(object sender, EventArgs e)
        {

            string phone = "+90" + txtPhone.Text;
            string message = txtMessage.Text;


            // Telefon numarası format kontrolü (+90 ile başlayan 12 hane)
            if (!Regex.IsMatch(phone, @"^\+90\d{10}$"))
            {
                MessageBox.Show("Geçerli bir telefon numarası girin. (0 olmadan 10 hane)", "Hatalı Numara", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Lütfen telefon numarası ve mesaj girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (message.Length > 300)
            {
                MessageBox.Show("Mesaj 300 karakterden fazla olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var senderObj = new SmsSender();
            await senderObj.SendSmsAsync(phone, message);

            MessageBox.Show("Mesaj başarıyla gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {phone} - {message}";
            File.AppendAllText("sms_log.txt", logEntry + Environment.NewLine);


            LogYaz($"SMS gönderildi: {phone} → \"{message}\" (Karakter: {message.Length})", true);


            notifyIcon1.BalloonTipTitle = "Başarılı!";
            notifyIcon1.BalloonTipText = "Mesaj başarıyla gönderildi!";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(3000); // 3000 = 3 saniye


            txtPhone.Clear();
            txtMessage.Clear();

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            int currentLength = txtMessage.Text.Length;
            int maxLength = 160;

            labelCharCount.Text = $"Karakter: {currentLength} / {maxLength}";

            if (currentLength > maxLength)
            {
                labelCharCount.ForeColor = Color.Red;
                btnSend.Enabled = false; // Butonu devre dışı bırak
            }
            else
            {
                labelCharCount.ForeColor = Color.Gray;
                btnSend.Enabled = true; // Butonu tekrar aktif et
            }
        }

        private void bos_Load(object sender, EventArgs e)
        {
            LoadContacts();
            tabPlanlananlar.Text = "Planlanan Mesajlar";

            dtScheduledTime.Format = DateTimePickerFormat.Custom;
            dtScheduledTime.CustomFormat = "dd.MM.yyyy HH:mm";
            dtScheduledTime.ShowUpDown = true;

            if (File.Exists("geribildirim.txt"))
            {
                string[] geriBildiriler = File.ReadAllLines("geribildirim.txt", Encoding.UTF8);
                foreach (string satir in geriBildiriler)
                {
                    lstGeriBildiriler.Items.Add(satir);
                }
            }

            // Eğer dosya varsa onu oku, yoksa varsayılan mesajları yükle
            if (File.Exists("hazir_mesajlar.txt"))
            {
                string[] mesajlar = File.ReadAllLines("hazir_mesajlar.txt", Encoding.UTF8);
                foreach (string mesaj in mesajlar)
                {
                    if (!string.IsNullOrWhiteSpace(mesaj))
                    {
                        lstHazirMesajlar.Items.Add(mesaj.Trim());
                    }
                }
            }
            else
            {
                // İlk kez açıldıysa varsayılan mesajları ekle
                lstHazirMesajlar.Items.Add("Randevunuz yarın saat 14:00’tedir.");
                lstHazirMesajlar.Items.Add("Ödemenizi unutmayınız lütfen.");
                lstHazirMesajlar.Items.Add("Doğum gününüz kutlu olsun!");
                lstHazirMesajlar.Items.Add("Kargonuz teslim edilmiştir.");
                lstHazirMesajlar.Items.Add("İletişim için bizi arayabilirsiniz.");
                lstHazirMesajlar.Items.Add("Yarın karının doğum günü, unutma.");

                // Ve bu varsayılanları dosyaya yaz
                File.WriteAllLines("hazir_mesajlar.txt", lstHazirMesajlar.Items.Cast<string>(), Encoding.UTF8);
            }
            dgvPlanlananlar.Columns.Add("TarihSaat", "Planlanan Zaman");
            dgvPlanlananlar.Columns.Add("Telefon", "Telefon Numarası");
            dgvPlanlananlar.Columns.Add("Mesaj", "Mesaj");
            dgvPlanlananlar.AutoGenerateColumns = false;


        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFilterLogs_Click(object sender, EventArgs e)
        {
            lstGecmisSonuc.Clear(); // Listeyi temizle

            string logDosyaYolu = "sms_log.txt";
            if (!File.Exists(logDosyaYolu))
            {
                MessageBox.Show("Log dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime baslangic = dtGecmisBaslangic.Value;
            DateTime bitis = dtGecmisBitis.Value;

            string[] satirlar = File.ReadAllLines(logDosyaYolu);

            foreach (string satir in satirlar)
            {
                if (satir.Length < 19) continue;

                string zamanStr = satir.Substring(0, 19);

                if (DateTime.TryParseExact(zamanStr, "yyyy-MM-dd HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime zamanDamgasi))
                {
                    if (zamanDamgasi >= baslangic && zamanDamgasi <= bitis)
                    {
                        lstGecmisSonuc.AppendText(satir + Environment.NewLine);
                    }
                }
            }
        }


        private void txtMessage_TextChanged_1(object sender, EventArgs e)
        {
            string karakter = txtMessage.TextLength.ToString();
            labelCharCount.Text = $"Karakter: {karakter} / 300";
        }

        private void labelCharCount_Click(object sender, EventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("İsim ve telefon boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ⛔️ Aynı telefon numarası varsa ekleme
            foreach (DataGridViewRow row in dgvContacts.Rows)
            {
                if (!row.IsNewRow && row.Cells[1].Value?.ToString() == phone)
                {
                    MessageBox.Show("Bu telefon numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // ✅ Kayıt ekle
            dgvContacts.Rows.Add(name, phone);
            txtName.Clear();
            txtPhone.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0) // Bir satır seçiliyse
            {
                DialogResult result = MessageBox.Show(
                    "Seçili kişiyi silmek istediğinizden emin misiniz?",
                    "Kişi Sil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    dgvContacts.Rows.RemoveAt(dgvContacts.SelectedRows[0].Index); // Satırı sil
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kişi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveContacts_Click(object sender, EventArgs e)
        {// 1. Önce textbox'lardaki veriyi kontrol et
            string filePath = "rehber.txt"; // Kayıt dosyası

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    HashSet<string> kaydedilenler = new HashSet<string>();

                    foreach (DataGridViewRow row in dgvContacts.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string name = row.Cells[0].Value?.ToString().Trim();
                            string phone = row.Cells[1].Value?.ToString().Trim();

                            // Boşluk kontrolü ve tekrar kontrolü
                            if (!string.IsNullOrWhiteSpace(name) &&
                                !string.IsNullOrWhiteSpace(phone))
                            {
                                string satir = $"{name} - {phone}";

                                if (kaydedilenler.Add(satir)) // Eğer daha önce eklenmemişse
                                {
                                    sw.WriteLine(satir);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Kişiler başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvContacts.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool visible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                        {
                            visible = true;
                            break;
                        }
                    }
                    row.Visible = visible;
                }
            }
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSchedule.Checked)
            {
                if (dtScheduledTime.Value <= DateTime.Now)
                {
                    MessageBox.Show("Lütfen gelecekte bir zaman seçin!");
                    chkSchedule.Checked = false;
                    return;
                }

                timerScheduled.Start(); // zamanı kontrol etmeye başla

                // 🔽 PLANLANANLAR LİSTESİNE EKLEME BURAYA!
                dgvPlanlananlar.Rows.Add(
                    dtScheduledTime.Value.ToString("dd.MM.yyyy HH:mm"),
                    "+90" + txtPhone.Text.Trim(),
                    txtMessage.Text.Trim()
                );

                string planSatiri = $"{dtScheduledTime.Value:dd.MM.yyyy HH:mm}|+90{txtPhone.Text.Trim()}|{txtMessage.Text.Trim()}";
                File.AppendAllText("planlanan_smsler.txt", planSatiri + Environment.NewLine, Encoding.UTF8);
            }
            else
            {
                timerScheduled.Stop(); // kutucuk kaldırılırsa zaman saymayı durdur
            }

        }

        private void timerScheduled_Tick(object sender, EventArgs e)
        {
            if (!chkSchedule.Checked)
            {
                return;
            }

            DateTime suan = DateTime.Now;
            DateTime hedefZaman = dtScheduledTime.Value;

            if (suan >= hedefZaman)
            {
                timerScheduled.Stop();
                chkSchedule.Checked = false;

                btnSend.PerformClick(); // SMS Gönder butonuna otomatik tıkla
                MessageBox.Show("Zamanlanmış SMS gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstHazirMesajlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHazirMesajlar.SelectedItem != null)
            {
                if (lstHazirMesajlar.SelectedItem != null)
                {
                    txtMessage.Clear(); // Önce kutuyu temizle
                    txtMessage.Text = lstHazirMesajlar.SelectedItem.ToString(); // Sonra yeni mesajı yaz
                }
            }
        }

        private void lstHazirMesajlar_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Seçili mi kontrol et
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Arka plan rengi
            Color bgColor = selected ? Color.LightBlue : lstHazirMesajlar.BackColor;
            Color textColor = selected ? Color.Black : lstHazirMesajlar.ForeColor;

            e.Graphics.FillRectangle(new SolidBrush(bgColor), e.Bounds);
            e.Graphics.DrawString(lstHazirMesajlar.Items[e.Index].ToString(),
                                  e.Font,
                                  new SolidBrush(textColor),
                                  e.Bounds);

            e.DrawFocusRectangle(); // odak kutusu
        }

        private void btnMesajEkle_Click(object sender, EventArgs e)
        {
            string yeniMesaj = txtYeniMesaj.Text.Trim();

            if (!string.IsNullOrWhiteSpace(yeniMesaj))
            {
                lstHazirMesajlar.Items.Add(yeniMesaj);
                File.AppendAllText("hazir_mesajlar.txt", yeniMesaj + Environment.NewLine, Encoding.UTF8);
                txtYeniMesaj.Clear();
                MessageBox.Show("Hazır mesaj eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen mesaj kutusuna bir şeyler yazın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnMesajSil_Click(object sender, EventArgs e)
        {
            if (lstHazirMesajlar.SelectedItem != null)
            {
                string silinecekMesaj = lstHazirMesajlar.SelectedItem.ToString();

                // ListBox'tan sil
                lstHazirMesajlar.Items.Remove(silinecekMesaj);

                // Dosyadaki tüm mesajları oku
                List<string> mesajlar = File.ReadAllLines("hazir_mesajlar.txt", Encoding.UTF8).ToList();

                // Seçilen mesajı çıkar
                mesajlar.RemoveAll(m => m.Trim() == silinecekMesaj.Trim());

                // Güncellenmiş listeyi yeniden dosyaya yaz
                File.WriteAllLines("hazir_mesajlar.txt", mesajlar, Encoding.UTF8);

                MessageBox.Show("Mesaj silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir mesaj seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPlanSil_Click(object sender, EventArgs e)
        {
            if (dgvPlanlananlar.SelectedRows.Count > 0)
            {
                // 1. Seçili satırı al
                DataGridViewRow seciliSatir = dgvPlanlananlar.SelectedRows[0];
                string zaman = seciliSatir.Cells[0].Value?.ToString();
                string telefon = seciliSatir.Cells[1].Value?.ToString();
                string mesaj = seciliSatir.Cells[2].Value?.ToString();

                // 2. DataGridView'den sil
                dgvPlanlananlar.Rows.Remove(seciliSatir);

                // 3. planlanan_smsler.txt dosyasını güncelle
                string[] satirlar = File.ReadAllLines("planlanan_smsler.txt", Encoding.UTF8);
                string silinecek = $"{zaman}|{telefon}|{mesaj}";

                var guncellenmis = satirlar.Where(s => s.Trim() != silinecek).ToArray();
                File.WriteAllLines("planlanan_smsler.txt", guncellenmis, Encoding.UTF8);

                MessageBox.Show("Seçili plan silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGeriBildir_Click(object sender, EventArgs e)
        {
            string geriBildirim = txtGeriBildirim.Text.Trim();

            if (!string.IsNullOrWhiteSpace(geriBildirim))
            {
                File.AppendAllText("geribildirim.txt", $"{DateTime.Now:yyyy-MM-dd HH:mm} - {geriBildirim}{Environment.NewLine}", Encoding.UTF8);
                MessageBox.Show("Geri bildiriminiz için teşekkürler!", "Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGeriBildirim.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen geri bildirim alanına bir şeyler yazın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
