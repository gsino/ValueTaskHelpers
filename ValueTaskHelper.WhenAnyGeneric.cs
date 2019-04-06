using System;
using System.Threading.Tasks;

namespace ValueTaskHelpers
{
    public static partial class ValueTaskHelper
    {
        public static async ValueTask<ValueTask<T>> WhenAny<T>(ValueTask<T> t1, ValueTask<T> t2)
        {
            if (t1.IsCompletedSuccessfully)
                return t1;
            if (t2.IsCompletedSuccessfully)
                return t2;
            var t1Task = t1.AsTask();
            var t2Task = t2.AsTask();
            var completedTask = await Task.WhenAny(t1Task, t2Task).ConfigureAwait(false);
            if (t1Task == completedTask)
                return t1;
            return t2;
        }

        public static async ValueTask<ValueTask<T>> WhenAny<T>(ValueTask<T> t1, ValueTask<T> t2, ValueTask<T> t3)
        {
            if (t1.IsCompletedSuccessfully)
                return t1;
            if (t2.IsCompletedSuccessfully)
                return t2;
            if (t3.IsCompletedSuccessfully)
                return t3;
            var t1Task = t1.AsTask();
            var t2Task = t2.AsTask();
            var t3Task = t3.AsTask();
            var completedTask = await Task.WhenAny(t1Task, t2Task, t3Task).ConfigureAwait(false);
            if (t1Task == completedTask)
                return t1;
            if (t2Task == completedTask)
                return t2;
            return t3;
        }

        public static async ValueTask<ValueTask<T>> WhenAny<T>(ValueTask<T> t1, ValueTask<T> t2, ValueTask<T> t3, ValueTask<T> t4)
        {
            if (t1.IsCompletedSuccessfully)
                return t1;
            if (t2.IsCompletedSuccessfully)
                return t2;
            if (t3.IsCompletedSuccessfully)
                return t3;
            if (t4.IsCompletedSuccessfully)
                return t4;
            var t1Task = t1.AsTask();
            var t2Task = t2.AsTask();
            var t3Task = t3.AsTask();
            var t4Task = t4.AsTask();
            var completedTask = await Task.WhenAny(t1Task, t2Task, t3Task, t4Task).ConfigureAwait(false);
            if (t1Task == completedTask)
                return t1;
            if (t2Task == completedTask)
                return t2;
            if (t3Task == completedTask)
                return t3;
            return t4;
        }

        public static async ValueTask<ValueTask<T>> WhenAny<T>(ValueTask<T> t1, ValueTask<T> t2, ValueTask<T> t3, ValueTask<T> t4, ValueTask<T> t5)
        {
            if (t1.IsCompletedSuccessfully)
                return t1;
            if (t2.IsCompletedSuccessfully)
                return t2;
            if (t3.IsCompletedSuccessfully)
                return t3;
            if (t4.IsCompletedSuccessfully)
                return t4;
            if (t5.IsCompletedSuccessfully)
                return t5;
            var t1Task = t1.AsTask();
            var t2Task = t2.AsTask();
            var t3Task = t3.AsTask();
            var t4Task = t4.AsTask();
            var t5Task = t5.AsTask();
            var completedTask = await Task.WhenAny(t1Task, t2Task, t3Task, t4Task, t5Task).ConfigureAwait(false);
            if (t1Task == completedTask)
                return t1;
            if (t2Task == completedTask)
                return t2;
            if (t3Task == completedTask)
                return t3;
            if (t4Task == completedTask)
                return t4;
            return t5;
        }

        public static async ValueTask<ValueTask<T>> WhenAny<T>(ValueTask<T> t1, ValueTask<T> t2, ValueTask<T> t3, ValueTask<T> t4, ValueTask<T> t5, ValueTask<T> t6)
        {
            if (t1.IsCompletedSuccessfully)
                return t1;
            if (t2.IsCompletedSuccessfully)
                return t2;
            if (t3.IsCompletedSuccessfully)
                return t3;
            if (t4.IsCompletedSuccessfully)
                return t4;
            if (t5.IsCompletedSuccessfully)
                return t5;
            if (t6.IsCompletedSuccessfully)
                return t6;
            var t1Task = t1.AsTask();
            var t2Task = t2.AsTask();
            var t3Task = t3.AsTask();
            var t4Task = t4.AsTask();
            var t5Task = t5.AsTask();
            var t6Task = t6.AsTask();
            var completedTask = await Task.WhenAny(t1Task, t2Task, t3Task, t4Task, t5Task, t6Task).ConfigureAwait(false);
            if (t1Task == completedTask)
                return t1;
            if (t2Task == completedTask)
                return t2;
            if (t3Task == completedTask)
                return t3;
            if (t4Task == completedTask)
                return t4;
            if (t5Task == completedTask)
                return t5;
            return t6;
        }

        public static async ValueTask<ValueTask<T>> WhenAny<T>(ValueTask<T> t1, ValueTask<T> t2, ValueTask<T> t3, ValueTask<T> t4, ValueTask<T> t5, ValueTask<T> t6, ValueTask<T> t7)
        {
            if (t1.IsCompletedSuccessfully)
                return t1;
            if (t2.IsCompletedSuccessfully)
                return t2;
            if (t3.IsCompletedSuccessfully)
                return t3;
            if (t4.IsCompletedSuccessfully)
                return t4;
            if (t5.IsCompletedSuccessfully)
                return t5;
            if (t6.IsCompletedSuccessfully)
                return t6;
            if (t7.IsCompletedSuccessfully)
                return t7;
            var t1Task = t1.AsTask();
            var t2Task = t2.AsTask();
            var t3Task = t3.AsTask();
            var t4Task = t4.AsTask();
            var t5Task = t5.AsTask();
            var t6Task = t6.AsTask();
            var t7Task = t7.AsTask();
            var completedTask = await Task.WhenAny(t1Task, t2Task, t3Task, t4Task, t5Task, t6Task, t7Task).ConfigureAwait(false);
            if (t1Task == completedTask)
                return t1;
            if (t2Task == completedTask)
                return t2;
            if (t3Task == completedTask)
                return t3;
            if (t4Task == completedTask)
                return t4;
            if (t5Task == completedTask)
                return t5;
            if (t6Task == completedTask)
                return t6;
            return t7;
        }

        public static async ValueTask<ValueTask<T>> WhenAny<T>(ValueTask<T> t1, ValueTask<T> t2, ValueTask<T> t3, ValueTask<T> t4, ValueTask<T> t5, ValueTask<T> t6, ValueTask<T> t7, ValueTask<T> t8)
        {
            if (t1.IsCompletedSuccessfully)
                return t1;
            if (t2.IsCompletedSuccessfully)
                return t2;
            if (t3.IsCompletedSuccessfully)
                return t3;
            if (t4.IsCompletedSuccessfully)
                return t4;
            if (t5.IsCompletedSuccessfully)
                return t5;
            if (t6.IsCompletedSuccessfully)
                return t6;
            if (t7.IsCompletedSuccessfully)
                return t7;
            if (t8.IsCompletedSuccessfully)
                return t8;
            var t1Task = t1.AsTask();
            var t2Task = t2.AsTask();
            var t3Task = t3.AsTask();
            var t4Task = t4.AsTask();
            var t5Task = t5.AsTask();
            var t6Task = t6.AsTask();
            var t7Task = t7.AsTask();
            var t8Task = t8.AsTask();
            var completedTask = await Task.WhenAny(t1Task, t2Task, t3Task, t4Task, t5Task, t6Task, t7Task, t8Task).ConfigureAwait(false);
            if (t1Task == completedTask)
                return t1;
            if (t2Task == completedTask)
                return t2;
            if (t3Task == completedTask)
                return t3;
            if (t4Task == completedTask)
                return t4;
            if (t5Task == completedTask)
                return t5;
            if (t6Task == completedTask)
                return t6;
            if (t7Task == completedTask)
                return t7;
            return t8;
        }
    }
}
