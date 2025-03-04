namespace sroNumber4
{
    public partial class Form1 : Form
    {
        private List<int> originalList;
        private List<int> processedList;
        private TextBox txtOutput;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }


     
        private List<int> CreateRandomList(int count, int minValue, int maxValue)
        {
            return Enumerable.Range(0, count)
                .Select(_ => random.Next(minValue, maxValue + 1))
                .ToList();
        }

      
        private void DisplayList(List<int> list, string message = "")
        {
            txtOutput.Clear();
            txtOutput.AppendText($"{message}\r\n");
            txtOutput.AppendText(string.Join(", ", list));
        }

  
        private bool IsPowerOfThree(int number)
        {
            if (number <= 0) return false;
            while (number % 3 == 0)
            {
                number /= 3;
            }
            return number == 1;
        }

       
        private int CountElementsWithQ(List<int> list)
        {
            return list.Count(num => IsPowerOfThree(num));
        }

     
        private List<int> RemoveElementsWithT(List<int> list)
        {
            return list.Where(num => num.ToString().Contains('5')).ToList();
        }

       
        private void BtnCreateList_Click(object sender, EventArgs e)
        {
          
            originalList = CreateRandomList(15, 1, 250);
            processedList = new List<int>(originalList);
            DisplayList(processedList, "������ ��������� ������:");
        }

        private void BtnDisplayList_Click(object sender, EventArgs e)
        {
            if (processedList != null && processedList.Count > 0)
            {
                DisplayList(processedList, "������� ������:");
            }
            else
            {
                txtOutput.Text = "������ ���� ��� �� ������!";
            }
        }

        private void BtnCountQ_Click(object sender, EventArgs e)
        {
            if (processedList != null && processedList.Count > 0)
            {
                int countQ = CountElementsWithQ(processedList);
                txtOutput.Text = $"���������� ��������� �� ��������� Q (������� ������): {countQ}";
            }
            else
            {
                txtOutput.Text = "������ ���� ��� �� ������!";
            }
        }

        private void BtnRemoveT_Click(object sender, EventArgs e)
        {
            if (processedList != null && processedList.Count > 0)
            {
                processedList = RemoveElementsWithT(processedList);
                DisplayList(processedList, "������ ����� �������� ��������� � ��������� T:");
            }
            else
            {
                txtOutput.Text = "������ ���� ��� �� ������!";
            }
        }

   
        private void BtnClearList_Click(object sender, EventArgs e)
        {
            if (processedList != null)
            {
                processedList.Clear();
                originalList = null;
                txtOutput.Text = "������ ��������� ������.";
            }
            else
            {
                txtOutput.Text = "������ ��� ����.";
            }
        }
    }
}