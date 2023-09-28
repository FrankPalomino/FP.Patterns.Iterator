using System.Collections;

namespace FP.Patterns.Iterator.Exercice1
{
    public class TaskItem
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        public TaskItem(string name)
        {
            Name = name;
            IsComplete = false;
        }
    }
}
