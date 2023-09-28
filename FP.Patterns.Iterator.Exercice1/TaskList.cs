using System.Collections;

namespace FP.Patterns.Iterator.Exercice1
{
    public class TaskList : IEnumerable<TaskItem>
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
       
        public void AddTask(string name)
        {
            _tasks.Add(new TaskItem(name));
        }

        public IEnumerator<TaskItem> GetEnumerator()
        {
            return _tasks.GetEnumerator();
        }

        public void Remove(TaskItem task)
        {
            _tasks.Remove(task);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
