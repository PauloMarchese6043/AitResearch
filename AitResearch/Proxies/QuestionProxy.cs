using AitResearch.DbTableModels;

namespace AitResearch.Proxies
{
    public class QuestionProxy
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int NextQuestionId { get; set; }

        public QuestionProxy() { }
        public QuestionProxy(QUESTION model)
        {
            if (model != null)
            {
                Id = model.ID;
                Text = model.TEXT;
                Type = model.TYPE;
                NextQuestionId = model.NEXT_QUESTION_ID != null ? model.NEXT_QUESTION_ID.Value : 0;
            }
        }
    }
}