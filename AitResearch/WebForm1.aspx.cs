using AitResearch.DbTableModels;
using AitResearch.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AitResearch
{
    public partial class WebForm1 : Page
    {
        private static int currentQuestionId = 0;
        DatabaseContext dbContext = new DatabaseContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            QuestionProxy question = GetNextQuestion();
            if (question != null)
            {
                QuestionLabel.Text = question.Text;

                switch (question.Type)
                {
                    case "text":
                        TextBox textBox = new TextBox();
                        textBox.ID = "AnswerTxtBox";
                        PlaceHolder1.Controls.Add(textBox);
                        break;
                    case "radio":
                        RadioButtonList radioButtonList = new RadioButtonList();
                        GetQuestionOptions(question.Id).ForEach(x => radioButtonList.Items.Add(new ListItem(x.Text)));

                        PlaceHolder1.Controls.Add(radioButtonList);
                        break;
                    case "checkbox":
                        CheckBoxList checkBox = new CheckBoxList();
                        List<QuestionOptionProxy> opts = GetQuestionOptions(question.Id);
                        opts.ForEach(x => checkBox.Items.Add(new ListItem(x.Text)));
                        checkBox.DataSource = opts;

                        PlaceHolder1.Controls.Add(checkBox);
                        break;
                }
            }
        }

        protected void NextBtn_Click(object sender, EventArgs e)
        {

        }

        private QuestionProxy GetNextQuestion()
        {
            currentQuestionId++;
            return new QuestionProxy(dbContext.QUESTIONS.Where(x => x.ID == currentQuestionId).FirstOrDefault());
        }

        private List<QuestionOptionProxy> GetQuestionOptions(int questionId)
        {
            return dbContext.QUESTION_OPTIONS.Where(x => x.QUESTION_ID == questionId)
                .ToList().Select(y => new QuestionOptionProxy(y)).ToList();
        }
    }
}