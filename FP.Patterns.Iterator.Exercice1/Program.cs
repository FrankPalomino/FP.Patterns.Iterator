using FP.Patterns.Iterator.Exercice1;

TaskList taskList = new TaskList();

taskList.AddTask("Task 1");
taskList.AddTask("Task 2");
taskList.AddTask("Task 3");

foreach(TaskItem task in taskList)
{
    Console.WriteLine(task.Name);
}