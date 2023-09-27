using static System.Net.Mime.MediaTypeNames;

namespace CaesarCipher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void encodeBtn_Click(object sender, EventArgs e)
        {
            // Get data from text area and encode it
            string encoded = CaesarTool.Encrypt(inputArea.Text, 3);
            // Set encoded text to output area
            outputArea.Text = encoded;
        }

        private void encodeV2Btn_Click(object sender, EventArgs e)
        {
            // Get data from text area and encode it
            string encoded = CaesarTool.EncryptV2(inputArea.Text, 3);
            // Set encoded text to output area
            outputArea.Text = encoded;
        }
    }
}