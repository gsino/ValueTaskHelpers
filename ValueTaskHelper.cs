using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueTaskHelpers
{
    public static partial class ValueTaskHelper
    {
        public static async ValueTask WhenAll(this IEnumerable<ValueTask> valueTasks)
        {
            List<Task> tasks = null;
            foreach (var valueTask in valueTasks)
            {
                if (valueTask.IsCompletedSuccessfully)
                {
                    continue;
                }

                if (tasks == null)
                {
                    tasks = new List<Task>();
                }

                tasks.Add(valueTask.AsTask());
            }

            if (tasks == null)
            {
                return;
            }

            await Task.WhenAll(tasks).ConfigureAwait(false);
        }

        public static async ValueTask<T[]> WhenAll<T>(this IEnumerable<ValueTask<T>> valueTasks)
        {
            if (valueTasks == null) throw new ArgumentNullException(nameof(valueTasks));

            var valueTaskArray = valueTasks as IReadOnlyCollection<ValueTask<T>> ?? valueTasks.ToArray();

            var results = new T[valueTaskArray.Count];

            List<(int, Task<T>)> indexAndTasks = null;
            List<Task> tasksForWhenAll = null;

            var i = 0;
            foreach (var valueTask in valueTaskArray)
            {
                if (valueTask.IsCompletedSuccessfully)
                {
                    results[i] = valueTask.Result;
                    i++;
                    continue;
                }

                if (tasksForWhenAll == null)
                {
                    indexAndTasks = new List<(int, Task<T>)>(valueTaskArray.Count - i);
                    tasksForWhenAll = new List<Task>(valueTaskArray.Count - i);
                }

                var task = valueTask.AsTask();
                indexAndTasks.Add((i, task));
                tasksForWhenAll.Add(task);
                i++;
            }

            if (tasksForWhenAll == null)
            {
                //When all ValueTasks are synchronous.
                return results;
            }

            //When any ValueTask is asynchronous. 
            await Task.WhenAll(tasksForWhenAll).ConfigureAwait(false);

            foreach (var (index, task) in indexAndTasks)
            {
                results[index] = task.Result;
            }

            return results;
        }

        public static ValueTask<ValueTask> WhenAny(this IEnumerable<ValueTask> valueTasks)
        {
            if (valueTasks == null) throw new ArgumentNullException(nameof(valueTasks));

            var valueTaskArray = valueTasks as ValueTask[] ?? valueTasks.ToArray();
            return WhenAny(valueTaskArray);
        }

        public static async ValueTask<ValueTask> WhenAny(this ValueTask[] valueTasks)
        {
            if (valueTasks == null) throw new ArgumentNullException(nameof(valueTasks));

            foreach (var valueTask in valueTasks)
            {
                if (valueTask.IsCompletedSuccessfully)
                {
                    return valueTask;
                }
            }

            //Create task for Task.WhenAny
            var tasks = new Task[valueTasks.Length];
            for (int i = 0; i < valueTasks.Length; i++)
            {
                tasks[i] = valueTasks[i].AsTask();
            }

            var completedTask = await Task.WhenAny(tasks).ConfigureAwait(false);

            for (var i = 0; i < tasks.Length; i++)
            {
                if (tasks[i] == completedTask)
                {
                    return valueTasks[i];
                }
            }

            throw new Exception();
        }

        public static ValueTask<ValueTask<T>> WhenAny<T>(this IEnumerable<ValueTask<T>> valueTasks)
        {
            if (valueTasks == null) throw new ArgumentNullException(nameof(valueTasks));

            var valueTaskArray = valueTasks as ValueTask<T>[] ?? valueTasks.ToArray();
            return WhenAny(valueTaskArray);
        }

        public static async ValueTask<ValueTask<T>> WhenAny<T>(this ValueTask<T>[] valueTasks)
        {
            if (valueTasks == null) throw new ArgumentNullException(nameof(valueTasks));

            foreach (var valueTask in valueTasks)
            {
                if (valueTask.IsCompletedSuccessfully)
                {
                    return valueTask;
                }
            }

            //Create task for Task.WhenAny
            var tasks = new Task[valueTasks.Length];
            for (int i = 0; i < valueTasks.Length; i++)
            {
                tasks[i] = valueTasks[i].AsTask();
            }

            var completedTask = await Task.WhenAny(tasks).ConfigureAwait(false);

            for (var i = 0; i < tasks.Length; i++)
            {
                if (tasks[i] == completedTask)
                {
                    return valueTasks[i];
                }
            }

            throw new Exception();
        }
    }
}
