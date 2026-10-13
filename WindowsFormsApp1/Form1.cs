using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // keep the PrivateFontCollection alive for the lifetime of the form
        private PrivateFontCollection _privateFonts;
        // track whether the user selected two-player mode
        private bool _twoPlayerSelected = false;

        public Form1()
        {
            InitializeComponent();
            // Wire up player button click handlers
            this.one_playerbtn.Click += new EventHandler(this.one_playerbtn_Click);
            this.two_playerBtn.Click += new EventHandler(this.two_playerBtn_Click);

            // Wire up start button
            this.startBtn.Click += new EventHandler(this.startBtn_Click);
            // Wire up back button
            this.backBtn.Click += new EventHandler(this.backBtn_Click);
            // Wire up next level button
            this.nextlevelBtn.Click += new EventHandler(this.nextlevelBtn_Click);

            // Set initial visibility state: show only startup controls
            startgameLabel.Visible = true;
            testlabel.Visible = true;
            startBtn.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;

            chooselabel.Visible = false;
            one_playerbtn.Visible = false;
            two_playerBtn.Visible = false;
            InstructionLabel.Visible = false;
            iunderstandBtn.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            // Ensure level / player / completion UI is hidden at startup
            level_onelabel.Visible = false;
            player_onelabel.Visible = false;
            playerOnelabel.Visible = false;
            LevelOnelabel.Visible = false;
            completedlabel.Visible = false;
            nextlevelBtn.Visible = false;
            // hide player-two specific labels at startup
            levelone_Label2.Visible = false;
            playertwo_label.Visible = false;
            backBtn.Visible = false;

            // Apply rounded shapes to buttons/comboboxes if available
            ApplyRoundedShapes();

            // Populate serial port and baud rate combo boxes with sensible defaults
            try
            {
                var ports = SerialPort.GetPortNames();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(ports);
                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;

                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
                comboBox2.SelectedItem = "9600";
            }
            catch
            {
                // ignore
            }

            // Attempt to load the downloaded Proggy Clean font from /fonts/proggy_clean.ttf in application folder.
            // Place your downloaded proggy_clean.ttf into a folder named "fonts" inside the output directory
            // (or add it to the project and set Copy to Output Directory = "Copy if newer").
            LoadPixelFont("proggy_clean.ttf");

        }

        private void ApplyRoundedShapes()
        {
            // No rounded shapes applied. Keep default rectangular appearance for all controls.
            return;
        }

        private void SetRoundedRegion(Control c, int radius)
        {
            if (c == null) return;
            RectangleF rect = new RectangleF(0, 0, c.Width, c.Height);
            try
            {
                using (GraphicsPath gp = GetRoundPath(rect, radius))
                {
                    var old = c.Region;
                    c.Region = new Region(gp);
                    try { old?.Dispose(); } catch { }
                }
            }
            catch { }
        }

        System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                    Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When baud rate selection changes we don't need to repopulate ports.
            // Leave the selection as-is; user will pick a port from comboBox1.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the selected port changes we don't need to repopulate baud rates.
            // This handler remains so designer wiring is intact.
        }

        private void one_playerbtn_Click(object sender, EventArgs e)
        {
            ShowInstructions(sender);
        }

        private void two_playerBtn_Click(object sender, EventArgs e)
        {
            ShowInstructions(sender);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Require both combo boxes to have a selection before proceeding
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Please select both Port and Baud Rate before starting the game.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to open the selected serial port to connect to the Arduino
            try
            {
                string port = comboBox1.SelectedItem.ToString();
                int baud = int.Parse(comboBox2.SelectedItem.ToString());

                if (serialPort1.IsOpen)
                    serialPort1.Close();

                serialPort1.PortName = port;
                serialPort1.BaudRate = baud;
                serialPort1.DtrEnable = true;
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the selected serial port:\n" + ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hide initial startup controls
            startgameLabel.Visible = false;
            testlabel.Visible = false;
            startBtn.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;

            // Show player choice controls
            chooselabel.Visible = true;
            one_playerbtn.Visible = true;
            two_playerBtn.Visible = true;
        }

        private void ShowInstructions(object invokedBy)
        {
            // Only allow showing instructions when invoked by one_playerbtn or two_playerBtn
            if (!object.ReferenceEquals(invokedBy, one_playerbtn) && !object.ReferenceEquals(invokedBy, two_playerBtn))
                return;

            // Require both combo boxes to have a selection before proceeding
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Please select values for both combo boxes before starting.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hide setup controls
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            startgameLabel.Visible = false;
            one_playerbtn.Visible = false;
            two_playerBtn.Visible = false;
            // hide the chooser heading after a choice
            chooselabel.Visible = false;

            // hide picture (we use richTextBox for instructions) and show instruction UI
            InstructionLabel.Visible = true;
            iunderstandBtn.Visible = true;
            // Show the appropriate rich text box depending on which button invoked this method.
            try
            {
                if (object.ReferenceEquals(invokedBy, one_playerbtn))
                {
                    // One-player selected: show richTextBox1, hide richTextBox2
                    _twoPlayerSelected = false;
                    richTextBox1.Visible = true;
                    richTextBox2.Visible = false;
                    // show Back button so user can return to player choice
                    backBtn.Visible = true;
                }
                else if (object.ReferenceEquals(invokedBy, two_playerBtn))
                {
                    _twoPlayerSelected = true;
                    // Two-player selected: show richTextBox2, hide richTextBox1
                    richTextBox2.Visible = true;
                    richTextBox1.Visible = false;
                    // show Back button so user can return to player choice
                    backBtn.Visible = true;
                }
            }
            catch { }
        }

        /// <summary>
        /// Load a pixel font (.ttf) from the "fonts" folder next to the executable and apply to key controls.
        /// Place the .ttf into Project/fonts and set Copy to Output Directory = Copy if newer.
        /// </summary>
        /// <param name="fileName">font file name, e.g. PressStart2P.ttf</param>
        private void LoadPixelFont(string fileName)
        {
            try
            {
                // 1) Try to load font from embedded resources (if user added the .ttf to Properties.Resources)
                try
                {
                    // Try common resource names
                    string[] resourceNames = new[] { "proggy_clean", "ProggyClean", Path.GetFileNameWithoutExtension(fileName) };
                    foreach (var resName in resourceNames)
                    {
                        try
                        {
                            var stream = Properties.Resources.ResourceManager.GetStream(resName);
                            if (stream != null)
                            {
                                using (var ms = new MemoryStream())
                                {
                                    stream.CopyTo(ms);
                                    byte[] fontData = ms.ToArray();
                                    if (fontData.Length > 0)
                                    {
                                        _privateFonts = new PrivateFontCollection();
                                        IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                                        Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                                        _privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                                        Marshal.FreeCoTaskMem(fontPtr);
                                        ApplyPrivateFontFamily(_privateFonts);
                                        return; // done
                                    }
                                }
                            }
                            // Try GetObject in case resource was stored as byte[]
                            var obj = Properties.Resources.ResourceManager.GetObject(resName);
                            if (obj is byte[] bytes && bytes.Length > 0)
                            {
                                _privateFonts = new PrivateFontCollection();
                                IntPtr fontPtr = Marshal.AllocCoTaskMem(bytes.Length);
                                Marshal.Copy(bytes, 0, fontPtr, bytes.Length);
                                _privateFonts.AddMemoryFont(fontPtr, bytes.Length);
                                Marshal.FreeCoTaskMem(fontPtr);
                                ApplyPrivateFontFamily(_privateFonts);
                                return; // done
                            }
                        }
                        catch
                        {
                            // ignore and try next resource name
                        }
                    }
                }
                catch
                {
                    // ignore resource-loading failures and fall back to disk
                }
                // look in the application's fonts folder first
                string fontsDir = Path.Combine(Application.StartupPath, "fonts");
                string fontPath = Path.Combine(fontsDir, fileName);

                // If the provided fileName is an absolute path to a file, prefer it
                if (Path.IsPathRooted(fileName) && File.Exists(fileName))
                {
                    fontPath = fileName;
                }

                // If not found in app fonts, check a known download folder the user provided
                if (!File.Exists(fontPath))
                {
                    string userDownloadsFonts = @"C:\Users\KC\Downloads\WindowsFormsApp1fonts";
                    // try specific file inside that folder
                    string altPath = Path.Combine(userDownloadsFonts, fileName);
                    if (File.Exists(altPath))
                        fontPath = altPath;
                    else if (Directory.Exists(userDownloadsFonts))
                    {
                        // try to find any .ttf in that folder
                        var ttf = Directory.GetFiles(userDownloadsFonts, "*.ttf").FirstOrDefault();
                        if (!string.IsNullOrEmpty(ttf))
                            fontPath = ttf;
                    }
                }

                if (!File.Exists(fontPath))
                    return; // font not provided, skip

                _privateFonts = new PrivateFontCollection();
                _privateFonts.AddFontFile(fontPath);

                if (_privateFonts.Families.Length == 0)
                    return;

                ApplyPrivateFontFamily(_privateFonts);
            }
            catch
            {
                // ignore failures — app will continue with system fonts
            }
        }

        private void ApplyPrivateFontFamily(PrivateFontCollection pfc)
        {
            var family = pfc.Families[0];

            // Create fonts at sizes used in the UI
            var titleFont = new Font(family, 32f, FontStyle.Regular);
            var buttonFont = new Font(family, 18f, FontStyle.Regular);
            var smallFont = new Font(family, 12f, FontStyle.Regular);

            // Apply small font to all controls by default
            ApplyFontToControls(this, smallFont);

            // Override sizes for specific controls
            if (startgameLabel != null) startgameLabel.Font = titleFont;
            if (one_playerbtn != null) one_playerbtn.Font = buttonFont;
            if (two_playerBtn != null) two_playerBtn.Font = buttonFont;
            if (iunderstandBtn != null) iunderstandBtn.Font = new Font(family, 14f);
            if (InstructionLabel != null) InstructionLabel.Font = new Font(family, 20f);
        }

        private void ApplyFontToControls(Control parent, Font font)
        {
            if (parent == null) return;
            foreach (Control c in parent.Controls)
            {
                try
                {
                    c.Font = font;
                }
                catch
                {
                    // ignore controls that can't set font
                }
                if (c.HasChildren) ApplyFontToControls(c, font);
            }
        }

        // Pill-shaping helper methods removed per user request.

        private async void iunderstandBtn_Click(object sender, EventArgs e)
        {
            // hide the instruction controls when user acknowledges
            InstructionLabel.Visible = false;
            iunderstandBtn.Visible = false;
            richTextBox1.Visible = false;
            // also hide both rich text instruction boxes
            richTextBox2.Visible = false;
            // hide back button as user proceeded
            backBtn.Visible = false;

            // Show initial small labels for level and player depending on mode
            try
            {
                if (_twoPlayerSelected)
                {
                    if (levelone_Label2 != null) levelone_Label2.Visible = true;
                    if (playertwo_label != null) playertwo_label.Visible = true;

                    // Ensure the larger/completed UI is hidden until delay elapses
                    if (playerOnelabel != null) playerOnelabel.Visible = false;
                    if (LevelOnelabel != null) LevelOnelabel.Visible = false;
                    if (completedlabel != null) completedlabel.Visible = false;
                    if (nextlevelBtn != null) nextlevelBtn.Visible = false;
                }
                else
                {
                    if (level_onelabel != null) level_onelabel.Visible = true;
                    if (player_onelabel != null) player_onelabel.Visible = true;

                    // Ensure the larger/completed UI is hidden until delay elapses
                    if (playerOnelabel != null) playerOnelabel.Visible = false;
                    if (LevelOnelabel != null) LevelOnelabel.Visible = false;
                    if (completedlabel != null) completedlabel.Visible = false;
                    if (nextlevelBtn != null) nextlevelBtn.Visible = false;
                }
            }
            catch { }

            // Wait 5 seconds then show the completed / next-level UI
            await Task.Delay(5000);

            try
            {
                // Hide the small labels shown initially and show the larger/completed UI
                if (_twoPlayerSelected)
                {
                    if (playertwo_label != null) playertwo_label.Visible = false;
                    if (levelone_Label2 != null) levelone_Label2.Visible = false;

                    // Set larger label to indicate player 2
                    if (playerOnelabel != null) { playerOnelabel.Text = "PLAYER 2"; playerOnelabel.Visible = true; }
                    if (LevelOnelabel != null) LevelOnelabel.Visible = true;
                    if (completedlabel != null) completedlabel.Visible = true;
                    if (nextlevelBtn != null) nextlevelBtn.Visible = true;
                }
                else
                {
                    if (player_onelabel != null) player_onelabel.Visible = false;
                    if (level_onelabel != null) level_onelabel.Visible = false;

                    if (playerOnelabel != null) playerOnelabel.Visible = true;
                    if (LevelOnelabel != null) LevelOnelabel.Visible = true;
                    if (completedlabel != null) completedlabel.Visible = true;
                    if (nextlevelBtn != null) nextlevelBtn.Visible = true;
                }
            }
            catch { }
        }

        private void nextlevelBtn_Click(object sender, EventArgs e)
        {
            // Hide the completed/next-level UI when user proceeds to next level
            try
            {
                if (playerOnelabel != null) playerOnelabel.Visible = false;
                if (LevelOnelabel != null) LevelOnelabel.Visible = false;
                if (completedlabel != null) completedlabel.Visible = false;
                if (nextlevelBtn != null) nextlevelBtn.Visible = false;
            }
            catch { }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Hide instruction UI
            InstructionLabel.Visible = false;
            iunderstandBtn.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;

            // Show player chooser controls
            chooselabel.Visible = true;
            one_playerbtn.Visible = true;
            two_playerBtn.Visible = true;

            // Hide back button
            backBtn.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
