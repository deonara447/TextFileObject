using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace TextFileObject
{
    public partial class Form1 : Form
    {
        List<HighScore> scores = new List<HighScore>();
      //  List<int> refBook = new List<int>();

        public Form1()
        {
            InitializeComponent();
            List<string> scoreList = File.ReadAllLines("BooksFile.txt").ToList();

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i+1];
                int score = Convert.ToInt32(scoreList[i]);


                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
               // refBook.Add(score);
            }
        }

        private void loadScoresButton_Click(object sender, EventArgs e)
        {
            
           //// Boolean test = scoreList.BinarySearch;
           // DisplayResults();
        }

        /// <summary>
        /// Take all values from the data object list, convert tem all to string
        /// values, store them all in a temp list of strings, and then save those
        /// values to an external file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScoresButton_Click(object sender, EventArgs e)
        {
            //// list to store all values from object list as strings
            //List<string> tempList = new List<string>();

            //// Add all info from each HighScore object to temp list
            //foreach (HighScore hs in scores)
            //{
            //    tempList.Add(hs.name);
            //    tempList.Add(Convert.ToString(hs.score));
            //}

            //File.WriteAllLines("scoreFile.txt", tempList);

            //Application.Exit();
        }

        private void sortScoresButton_Click(object sender, EventArgs e)
        {
          
          //  refBook = refBook.OrderBy(x => x).ToList();
            // DisplayResults();
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                scores = scores.OrderBy(x => x.score).ToList();
                int reference = Convert.ToInt32(nameInput.Text);
                string found1 = LinearSearch(scores, reference);
                string found2 = BinarySearch(scores, reference);
                scoreInput.Text = found2;
                nameRemove.Text = found1;
            }
            catch
            {
                outputLabel.Text = "must put in int";
            }




            //try
            //{
            //    string name = nameInput.Text;
            //    int score = Convert.ToInt32(scoreInput.Text);

            //    HighScore hs = new HighScore(name, score);
            //    scores.Add(hs);

            //    DisplayResults();
            //}
            //catch
            //{
            //    MessageBox.Show("Please enter a name and integer score");
            //}

            //nameInput.Text = "";
            //scoreInput.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //string name = nameRemove.Text;

            //int index = scores.FindIndex(score => score.name == name);

            //if (index >= 0)
            //{
            //    scores.RemoveAt(index);
            //    MessageBox.Show(name + " removed from scores");
            //    DisplayResults();
            //}
            //else
            //{
            //    MessageBox.Show(name + " is not in the list of scores");
            //}

            //nameRemove.Text = "";
        }

        public void DisplayResults()
        {
            //outputLabel.Text = "";

            //foreach (HighScore hs in scores)
            //{
            //    outputLabel.Text += hs.name + " " + hs.score + "\n";
            //}
        }
        public string LinearSearch(List<HighScore> searchList, int searchValue)
        {
            foreach (HighScore i in searchList)
            {
                if (i.score == searchValue)
                {
                    return i.name;
                }
            }
            return "not found";
        }
        public string BinarySearch(List<HighScore> searchList, int searchValue)
        {
            int low = 0;
            int high = searchList.Count - 1;

            while (high >= low)
            {
                int middle = (low + high);
             if (searchList[middle].score == searchValue)
                {
                    return searchList[middle].name;
                }
                else if (searchList[middle].score < searchValue)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return "not found";
        }
    }
}
