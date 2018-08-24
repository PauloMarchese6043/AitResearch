using AitResearch.DbTableModels;

namespace AitResearch.Proxies
{
    public class QuestionOptionProxy
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int QuestionId { get; set; }
        public int NextQuestionId { get; set; }

        public QuestionOptionProxy() { }
        public QuestionOptionProxy(QUESTION_OPTION model)
        {
            if (model != null)
            {
                Id = model.ID;
                Text = model.TEXT;
                QuestionId = model.QUESTION_ID;
                NextQuestionId = model.NEXT_QUESTION_ID != null ? model.NEXT_QUESTION_ID.Value : 0;
            }
        }
    }
}