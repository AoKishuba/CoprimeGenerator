using System.Diagnostics;
using System.IO;

namespace GearRatioGenerator
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int min = (int)MinTeethUD.Value;
            int max = (int)MaxTeethUD.Value;
            decimal desiredRatio = RatioNumeratorUD.Value / RatioDenominatorUD.Value;

            // Generate all possible coprime pairs within given range
            List<CoprimePair> pairList = [];
            for (int a = min; a <= max; a++)
            {
                foreach (int b in CoprimeGenerator.GenerateCoprimes(a, min, max))
                {
                    pairList.Add(new CoprimePair(a, b, desiredRatio));
                }
            }
            CoprimePair[] pairs = [.. pairList];


            // Normalize error magnitudes
            decimal greatestError = 0;
            // Find greatest error magnitude
            foreach (CoprimePair pair in pairs)
            {
                greatestError = pair.ErrorMagnitude > greatestError ? pair.ErrorMagnitude : greatestError;
            }
            // Normalize
            foreach (CoprimePair pair in pairs)
            {
                pair.NormalizedErrorMagnitude = pair.ErrorMagnitude / greatestError;
            }

            // Create filename from current time
            string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-ff") + ".csv";

            using var writer = new StreamWriter(fileName, append: true);
            FileStream fs = (FileStream)writer.BaseStream;

            // Column headers
            writer.WriteLine("Gear 1,Gear 2,Ratio,Error,Error Magnitude,Normalized Error Magnitude");
            // Write pairs to file
            foreach (CoprimePair pair in pairs)
            {
                writer.WriteLine(pair.ToString());
            }

            writer.Close();

            ShowFilenameAndDirectory(fileName);
        }

        /// <summary>
        /// Ensures max >= min
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinTeethUD_ValueChanged(object sender, EventArgs e)
        {
            MaxTeethUD.Minimum = MinTeethUD.Value;
        }

        /// <summary>
        /// Creates popup message displaying filename and directory of output file
        /// </summary>
        /// <param name="fileName">Auto-generated filename of text file containing output</param>
        static void ShowFilenameAndDirectory(string fileName)
        {
            // Initialize MessageBox variables
            string directoryName = Directory.GetCurrentDirectory();
            string message = $"File {fileName} has been saved at {directoryName}";
            string caption = "Procedure Created";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Dispay MessageBox
            MessageBox.Show(message, caption, buttons);
        }
    }
}
