namespace AitResearch.Migrations
{
    using AitResearch.DbTableModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "AitResearch.DbTableModels.DatabaseContext";
        }

        protected override void Seed(DatabaseContext context)
        {
            //QUESTION q1 = new QUESTION { TEXT = "What is your Name ?", TYPE = "text" };
            //QUESTION q2 = new QUESTION { TEXT = "What is your State ?", TYPE = "checkbox" };
            //QUESTION q3 = new QUESTION { TEXT = "What is your Gender ?", TYPE = "radio" };
            //context.QUESTIONS.AddOrUpdate(q1, q2, q3);

            //context.QUESTION_OPTIONS.AddOrUpdate(
            //    new QUESTION_OPTION { TEXT = "Victoria", QUESTION = q2 },
            //    new QUESTION_OPTION { TEXT = "New South Wales", QUESTION = q2 },
            //    new QUESTION_OPTION { TEXT = "Queensland", QUESTION = q2 },
            //    new QUESTION_OPTION { TEXT = "South Australia", QUESTION = q2 },
            //    new QUESTION_OPTION { TEXT = "Male", QUESTION = q3 },
            //    new QUESTION_OPTION { TEXT = "Female", QUESTION = q3 });
        }
    }
}
