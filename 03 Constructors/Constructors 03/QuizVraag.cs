using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_03
{
    class QuizVraag
    {
        internal string vraag;
        internal string antwoord;

        internal QuizVraag(string vraag, string antwoord)
        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }
    }
    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("Hier komt de vraag", "hier komt het antwoord");
    }
}
