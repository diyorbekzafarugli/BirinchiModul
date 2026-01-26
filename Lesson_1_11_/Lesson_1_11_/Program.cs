namespace Lesson_1_11_;

internal class Program
{
    static List<Question> questions = new List<Question>();

    static void Main(string[] args)
    {


        var question1 = new Question()
        {
            Text = "O'zbekiston poytaxti? ",
            A = "Olmaota",
            B = "Toshkent",
            C = "Jizzax",
            Answer = "B"
        };
        CreateQuestion(question1);


        var question2 = new Question()
        {
            Text = "O'zbekistonda nechta viloyat bor?",
            A = "12 ta",
            B = "20 ta",
            C = "12 ta viloyat hamda Qoraqalpog'iston Respublikasi",
            Answer = "C"

        };

        CreateQuestion(question2);
        DisplayQuestions();
    }


    static void CreateQuestion(Question question)
    {
        question.QuestionId = Guid.NewGuid();
        questions.Add(question);
    }


    static void DeleteQuestion(Guid guidId)
    {
        for (var i = 0; i < questions.Count; i++)
        {
            if (questions[i].QuestionId == guidId)
            {
                questions.RemoveAt(i);
                break;
            }
        }
    }


    static void UpdateQuestion(Guid questionId, Question newQuestion)
    {
        for (int i = 0; i < questions.Count; i++)
        {
            if (questions[i].QuestionId == questionId)
            {
                questions[i] = newQuestion;
                newQuestion.QuestionId = questionId;
                break;
            }

        }
    }


    static void DisplayQuestions()
    {
        foreach (var question in questions)
        {
            Console.WriteLine($"Question id : {question.QuestionId}");
            Console.WriteLine($"Savol : {question.Text}");
            Console.WriteLine($"A) {question.A}");
            Console.WriteLine($"B) {question.B}");
            Console.WriteLine($"C) {question.C}");
            Console.WriteLine($"Javobi : {question.Answer}");
            Console.WriteLine("--------------------");

        }
    }
}
