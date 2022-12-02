using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    

namespace Laba7
{
    public partial class Form1 : Form
    {
        int arrayType = 0;
        char[] separators = { ' ', '\n' };

        int[] array = null;
        int[,] matrix = null;
        int[][] jagArr = null;

        public Form1()
        {
            InitializeComponent();
        }

        static int[] MakeArray(int size)
        {
            Random rand = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = rand.Next(-99, 100);

            return array;
        }
        static int[,] MakeMatrix(int strings, int columns)
        {
            Random rand = new Random();
            int[,] matrix = new int[strings, columns];

            for (int i = 0; i < strings; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = rand.Next(-99, 100);

            return matrix;
        }
        static int[][] MakeJagArray(int size)
        {
            int stringLength;
            Random rand = new Random();
            int[][] jagArray = new int[size][];

            for(int i = 0; i < size; i++)
            {
                stringLength = rand.Next(1, 11);
                jagArray[i] = new int[stringLength];
                for (int j = 0; j < stringLength; j++)
                    jagArray[i][j] = rand.Next(-99, 100);
            }

            return jagArray;
        }

        int[] InputArray(string elements)
        {
            string[] mas = elements.Split(' ');
            int[] array = new int[mas.Length];

            for (int i = 0; i < mas.Length; i++)
            {
                bool check = int.TryParse(mas[i], out array[i]);
                if (!check) 
                {
                    ResultTextBox.Text = "Произошла ошибка ввода! Проверьте правильность ввода данных";
                    array = null;
                    break;
                }
            }

            return array;
        }
        int[,] InputMatrix(string elements, char[] separators)
        {
            int strings = CountStrings(elements);
            int columns = CountColumns(elements, 0);
            string[] mas = elements.Split( separators, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            int[,] matrix = new int[strings, columns];

                for (int i = 0; i < strings; i++)
                    for (int j = 0; j < columns; j++)
                    {
                        try { matrix[i, j] = int.Parse(mas[count]); }
                        catch 
                        { 
                            ResultTextBox.Text = "Произошла ошибка ввода! Проверьте правильность ввода данных";
                            matrix = null;
                            break;
                        }
                        count++;
                    }

            return matrix;
        }
        int[][] InputJagArr(string elements, char[] separators)
        {
            int size = CountStrings(elements);
            int stringLength;
            int startPos = 0;
            int count = 0;
            string[] mas = elements.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[][] jagArr = new int[size][];

            for (int i = 0; i < size; i++) 
            {
                stringLength = CountColumns(elements, startPos);
                jagArr[i] = new int[stringLength];
                try
                {
                    for (int j = 0; j < stringLength; j++)
                    {
                        jagArr[i][j] = int.Parse(mas[count]);
                        count++;
                    }
                }
                catch
                {
                    ResultTextBox.Text = "Произошла ошибка ввода! Проверьте правильность ввода данных";
                    jagArr = null;
                    break;
                }
                startPos = FindStartPos(elements, startPos);
            }

            return jagArr;
        }

        void PrintArray(int[] array)
        {
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    result += array[i];
                else result += array[i] + " ";
            }

            ResultTextBox.Text = result;
            arrayType = 1;
        }
        void PrintMatrix(int[,] matrix)
        {
            string result = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1 && i == matrix.GetLength(0) - 1)
                        result += matrix[i, j];
                    else if(j == matrix.GetLength(1) - 1)
                        result += matrix[i, j] + "\r\n";
                    else result += matrix[i, j] + " "; 
                }

            ResultTextBox.Text = result;
            arrayType = 2;
        }
        void PrintJagArr(int[][] jagArr)
        {
            string result = "";

            for(int i = 0; i < jagArr.GetLength(0); i++)
                for(int j = 0; j < jagArr[i].Length; j++)
                {
                    if (j == jagArr[i].Length - 1 && i == jagArr.GetLength(0) - 1)
                        result += jagArr[i][j];
                    else if (j == jagArr[i].Length - 1)
                        result += jagArr[i][j] + "\r\n";
                    else result += jagArr[i][j] + " ";
                }

            ResultTextBox.Text = result;
            AddStrNumberNUD.Maximum = jagArr.GetLength(0) + 1;
            arrayType = 3;
        }

        static void AddElements(ref int[] array, int addToArray)
        {
            int[] mas = new int[addToArray + array.Length];
            Random rand = new Random();

            for (int i = 0; i < addToArray; i++)
                mas[i] = rand.Next(-99, 100);

            Array.Copy(array, 0, mas, addToArray, array.Length);
            array = mas;
        }
        static void DeleteStrings(ref int[,] matrix, int firstStr, int lastStr)
        {

            int copyPos;
            int pastePos;
            int count = 0;

            firstStr--;
            lastStr--;

            int[,] newMatrix = new int[matrix.GetLength(0) - (lastStr - firstStr + 1), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i < firstStr || i > lastStr)
                {
                    copyPos = i * matrix.GetLength(1);
                    pastePos = count * newMatrix.GetLength(1);
                    Array.Copy(matrix, copyPos, newMatrix, pastePos, matrix.GetLength(1));
                    count++;
                }
            }

            matrix = newMatrix;
        }
        static void AddString(ref int[][] jagArr, int strNumber, int strLength)
        {
            int count = 0;
            int[][] newArray = new int[jagArr.GetLength(0) + 1][];
            Random rand = new Random();

            strNumber--;

            for (int i = 0; i < newArray.GetLength(0); i++)
            {

                if (i == strNumber)
                {
                    newArray[strNumber] = new int[strLength];
                    for (int j = 0; j < strLength; j++)
                        newArray[strNumber][j] = rand.Next(-99, 100);
                }
                else
                {
                    newArray[i] = new int[jagArr[count].Length];
                    Array.Copy(jagArr[count], newArray[i], jagArr[count].Length);
                    count++;
                }
            }

            jagArr = newArray;
        }

        void DefineArrayType(string fileName)
        {
            string a = "array";
            string b = "matrix";
            string c = "jagged";

            if ((fileName.Contains(a) && fileName.Contains(b)) || (fileName.Contains(a) && fileName.Contains(c)) || (fileName.Contains(b) && fileName.Contains(c)))
                ResultTextBox.Text = "Ошибка открытия файла";

            else if (fileName.Contains(a))
                array = StringToArray();

            else if (fileName.Contains(b))
                matrix = StringToMatrix();

            else if (fileName.Contains(c))
                jagArr = StringToJaggedArray();
        }
        int[] StringToArray()
        {
            string[] mas = ResultTextBox.Text.Split(' ');
            int[] array = new int[mas.Length];

            for (int i = 0; i < mas.Length; i++)
            {
                try { array[i] = int.Parse(mas[i]); }
                catch 
                { 
                    ResultTextBox.Text = "Ошибка открытия файла";
                    array = null;
                }
            }

            return array;
        }
        int[,] StringToMatrix()
        {
            int strings = CountStrings(ResultTextBox.Text);
            int columns = CountColumns(ResultTextBox.Text, 0);
            char[] separators = { ' ', '\n', '\r' };
            string[] mas = ResultTextBox.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[,] matrix = new int[strings, columns];
            int count = 0;

            for (int i = 0; i < strings; i++)
                for (int j = 0; j < columns; j++)
                {
                    try { matrix[i, j] = int.Parse(mas[count]); }
                    catch 
                    { 
                        ResultTextBox.Text = "Ошибка открытия файла";
                        matrix = null;
                    }
                    count++;
                }
            return matrix;
        }
        int[][] StringToJaggedArray()
        {
            int size = CountStrings(ResultTextBox.Text);
            int stringLength;
            int startPos = 0;
            int count = 0;
            char[] separators = { ' ', '\n', '\r' };
            string[] mas = ResultTextBox.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[][] jagArr = new int[size][];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    stringLength = CountColumns(ResultTextBox.Text, startPos);
                    jagArr[i] = new int[stringLength];
                    for (int j = 0; j < stringLength; j++)
                    {
                        jagArr[i][j] = int.Parse(mas[count]);
                        count++;
                    }

                    startPos = FindStartPos(ResultTextBox.Text, startPos);
                }
            }
            catch
            {
                ResultTextBox.Text = "Ошибка открытия файла";
                matrix = null;
            }
            return jagArr;
        }

        static int CountStrings(string elements)
        {
            int strings = 0;

            for (int i = 0; i < elements.Length; i++)
                if (elements[i] == '\n')
                    strings++;
            return strings;
        }
        static int CountColumns(string elements, int startPos)
        {
            int columns = 0;
            int i = startPos;

            while(elements[i] != '\n')
            {
                if (elements[i] == ' ')
                    columns++;
                i++;
            }

            return columns + 1; // пробелов на 1 меньше, чем столбцов
        }
        static int FindStartPos(string elements, int oldStartPos)
        {
            int i = oldStartPos;

            while (elements[i] != '\n')
                i++;

            return i + 1;
        }
        static string CreateFileName(string name, int arrayType)
        {
            switch (arrayType)
            {
                case 0:
                    {
                        name += "_empty.txt";
                        break;
                    }
                case 1:
                    {
                        name += "_array.txt";
                        break;
                    }
                case 2:
                    {
                        name += "_matrix.txt";
                        break;
                    }
                case 3:
                    {
                        name += "_jagged.txt";
                        break;
                    }
            }

            return name;
        }

        private void CreateArrBtn_Click(object sender, EventArgs e)
        {
            int size = (int)LengthInputNUD.Value;
            array = MakeArray(size);
            PrintArray(array);
        }
        private void CreateMatrixBtn_Click(object sender, EventArgs e)
        {
            int strings = (int)StringsNUD.Value;
            int columns = (int)ColumnsNUD.Value;

            matrix = MakeMatrix(strings, columns);
            PrintMatrix(matrix);
        }
        private void CreateJagArrBtn_Click(object sender, EventArgs e)
        {
            int size = (int)JagArrLengthInputNUD.Value;
            jagArr = MakeJagArray(size);
            PrintJagArr(jagArr);
        }

        private void InputArrBtn_Click(object sender, EventArgs e)
        {
            string elements;

            if (ArrInputTextBox.Text == "")
                ResultTextBox.Text = "Не введено ни одного элемента";
            else
            {
                elements = ArrInputTextBox.Text;
                array = InputArray(elements);
                if (array != null)
                {
                    PrintArray(array);
                }
            }
        }
        private void InputMatrixBtn_Click(object sender, EventArgs e)
        {
            string elements;

            if (MatrixInputTextBox.Text == "")
                ResultTextBox.Text = "Не введено ни одного элемента";
            else
            {
                elements = MatrixInputTextBox.Text + "\n";
                matrix = InputMatrix(elements, separators);
                if (matrix != null)
                {
                    PrintMatrix(matrix);
                }
            }
        }
        private void InputJagArrBtn_Click(object sender, EventArgs e)
        {
            string elements;

            if (JagArrInputTextBox.Text == "")
                ResultTextBox.Text = "Не введено ни одного элемента";
            else
            {
                elements = JagArrInputTextBox.Text + "\n";
                jagArr = InputJagArr(elements, separators);
                if (jagArr != null)
                {
                    PrintJagArr(jagArr);
                }
            }
        }

        private void AddElementsBtn_Click(object sender, EventArgs e)
        {
            if (array == null)
                ResultTextBox.Text = "Массив не создан! Создайте одномерный массив";
            else
            {
                int addToArray = (int)AddInputNUD.Value;
                AddElements(ref array, addToArray);
                PrintArray(array);
            }
        }  
        private void DelStringsBtn_Click(object sender, EventArgs e)
        {
            if (matrix == null || matrix.Length == 0)
            {
                ResultTextBox.Text = "Массив не создан! Создайте двумерный массив";
            }
            else if (FirstStrNUD.Value > matrix.GetLength(0) || LastStrNUD.Value > matrix.GetLength(0))
                ResultTextBox.Text += "\r\n" + "Произошла ошибка ввода! Проверьте правильность ввода данных";
            else
            {
                int firstStr = (int)FirstStrNUD.Value;
                int lastStr = (int)LastStrNUD.Value;
                DeleteStrings(ref matrix, firstStr, lastStr);
                PrintMatrix(matrix);
            }
        }
        private void AddStringBtn_Click(object sender, EventArgs e)
        {
            if (jagArr == null)
            {
                ResultTextBox.Text = "Массив не создан! Создайте рваный массив";
            }
            else
            {
                int strNumber = (int)AddStrNumberNUD.Value;
                int strLength = (int)AddStrLengthNUD.Value;
                AddString(ref jagArr, strNumber, strLength);
                PrintJagArr(jagArr);
            }
        }

        private void FirstStrNUD_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FirstStrNUD.Maximum = matrix.GetLength(0);
                LastStrNUD.Minimum = FirstStrNUD.Value;
                LastStrNUD.Maximum = matrix.GetLength(0);
            }
            catch (NullReferenceException) { ResultTextBox.Text = "Массив не создан! Создайте двумерный массив"; }
        }
        private void LastStrNUD_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FirstStrNUD.Maximum = matrix.GetLength(0);
                LastStrNUD.Minimum = FirstStrNUD.Value;
                LastStrNUD.Maximum = matrix.GetLength(0);
            }
            catch (NullReferenceException) { ResultTextBox.Text = "Массив не создан! Создайте двумерный массив"; }
        }    

        private void SaveFileBtn_Click(object sender, EventArgs e)
        { 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                fileName = CreateFileName(fileName, arrayType);
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine(ResultTextBox.Text);
                writer.Close();
            }
        }
        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                StreamReader reader = new StreamReader(fileName);
                ResultTextBox.Text = reader.ReadToEnd();
                reader.Close();

                DefineArrayType(fileName);
            }
        }
    }
}
