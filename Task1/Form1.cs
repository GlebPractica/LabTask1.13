using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private int _timeWork = 300; // 300 секунд время работы теста
        private int _currentTime; // Текущее время
        private int rndInd = 0; // index вопроса
        private int _countTrue = 0; // количество правильных ответов

        private List<Question> _questions; // Список с вопросами
        private Button[] _buttons; // Массив кнопок

        private List<string> _answers; // Список с ответами

        public Form1()
        {
            InitializeComponent();

            _buttons = new Button[3];
            _buttons[0] = Answ1;
            _buttons[1] = Answ2;
            _buttons[2] = Answ3;

            _buttons[0].Click += AsnwBttn_Click;
            _buttons[1].Click += AsnwBttn_Click;
            _buttons[2].Click += AsnwBttn_Click;
        }

        private void AsnwBttn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            progressBar1.Value++;

            if (btn.Text == _questions[rndInd].answers[0])
            {
                _countTrue++;
                _questions.RemoveAt(rndInd);
                ShowQue();
            }
            else
            {
                _questions.RemoveAt(rndInd);
                ShowQue();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Visible = false;
            lblQuestion.Visible = false;
            Answ1.Visible = false;
            Answ2.Visible = false;
            Answ3.Visible = false;

            _questions = new List<Question>();
            LoadQuesFromFile("questions.txt");
        }

        private void LoadQuesFromFile(string filePath)
        {
            // обязательным условием заполнения файла с вопросами является следующий шаблон "Вопрос;Ответ,Ответ,Ответ"

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        _questions.Add(new Question { question = parts[0], answers = parts[1].Split(',') });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                Environment.Exit(1);
            }
        }

        private void BttnStart_Click(object sender, EventArgs e)
        {
            StartSettings();
            timer.Start();
        }

        private void StartSettings()
        {
            BttnStart.Visible = false;

            lblTime.Visible = true;
            lblQuestion.Visible = true;
            Answ1.Visible = true;
            Answ2.Visible = true;
            Answ3.Visible = true;

            ShowQue();
        }

        private void ShowQue()
        {
            Random rand = new Random();

            if (_questions.Count < 1)
            {
                EndTest();
                MessageBox.Show($"Оценка {_countTrue}", "Результат");
                return;
            }

            rndInd = rand.Next(0, _questions.Count);

            lblQuestion.Text = _questions[rndInd].question;
            
            _answers = new List<string>(_questions[rndInd].answers);

            for (int i = 0; i < 3; i++)
            {
                int indb = rand.Next(0, _answers.Count);

                _buttons[i].Text = _answers[indb];
                _answers.RemoveAt(indb);
            }
        }

        private void EndTest()
        {
            lblQuestion.Visible = false;

            Answ1.Visible = false;
            Answ2.Visible = false;
            Answ3.Visible = false;
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _currentTime++;
            UpdLblTimer();
            if (_timeWork <= _currentTime)
            {
                timer.Stop();
                EndTest();
                MessageBox.Show("Время вышло");
                MessageBox.Show($"Оценка за тест: {_countTrue}");
            }
        }

        private void UpdLblTimer()
        {
            int remain = _timeWork - _currentTime;
            TimeSpan timeSpan = TimeSpan.FromSeconds(remain);
            lblTime.Text = $"{timeSpan:mm\\:ss}";
        }
    }
}
