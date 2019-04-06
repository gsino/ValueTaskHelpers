using System;
using System.Threading.Tasks;

namespace ValueTaskHelpers
{
    public static partial class ValueTaskHelper
    {
        public static async ValueTask<(T1, T2)> WhenAll<T1, T2>(ValueTask<T1> t1, ValueTask<T2> t2)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    return (t1.Result, t2.Result);
                }

                return (t1.Result, await t2.ConfigureAwait(false));
            }

            if (t2.IsCompletedSuccessfully)
            {
                return (await t1.ConfigureAwait(false), t2.Result);
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
            return (t1.Result, t2.Result);
        }

        public static async ValueTask<(T1, T2, T3)> WhenAll<T1, T2, T3>(ValueTask<T1> t1, ValueTask<T2> t2, ValueTask<T3> t3)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        return (t1.Result, t2.Result, t3.Result);
                    }

                    return (t1.Result, t2.Result, await t3.ConfigureAwait(false));
                }

                if (t3.IsCompletedSuccessfully)
                {
                    return (t1.Result, await t2.ConfigureAwait(false), t3.Result);
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result);
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    return (await t1.ConfigureAwait(false), t2.Result, t3.Result);
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result);
            }

            if (t3.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result);
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
            return (t1.Result, t2.Result, t3.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4)> WhenAll<T1, T2, T3, T4>(ValueTask<T1> t1, ValueTask<T2> t2, ValueTask<T3> t3, ValueTask<T4> t4)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        if (t4.IsCompletedSuccessfully)
                        {
                            return (t1.Result, t2.Result, t3.Result, t4.Result);
                        }

                        return (t1.Result, t2.Result, t3.Result, await t4.ConfigureAwait(false));
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        return (t1.Result, t2.Result, await t3.ConfigureAwait(false), t4.Result);
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result);
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        return (t1.Result, await t2.ConfigureAwait(false), t3.Result, t4.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result);
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result);
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        return (await t1.ConfigureAwait(false), t2.Result, t3.Result, t4.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result);
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result);
            }

            if (t3.IsCompletedSuccessfully)
            {
                if (t4.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result);
            }

            if (t4.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result);
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
            return (t1.Result, t2.Result, t3.Result, t4.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4, T5)> WhenAll<T1, T2, T3, T4, T5>(ValueTask<T1> t1, ValueTask<T2> t2, ValueTask<T3> t3, ValueTask<T4> t4, ValueTask<T5> t5)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        if (t4.IsCompletedSuccessfully)
                        {
                            if (t5.IsCompletedSuccessfully)
                            {
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                            }

                            return (t1.Result, t2.Result, t3.Result, t4.Result, await t5.ConfigureAwait(false));
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            return (t1.Result, t2.Result, t3.Result, await t4.ConfigureAwait(false), t5.Result);
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            return (t1.Result, t2.Result, await t3.ConfigureAwait(false), t4.Result, t5.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            return (t1.Result, await t2.ConfigureAwait(false), t3.Result, t4.Result, t5.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            return (await t1.ConfigureAwait(false), t2.Result, t3.Result, t4.Result, t5.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
            }

            if (t3.IsCompletedSuccessfully)
            {
                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
            }

            if (t4.IsCompletedSuccessfully)
            {
                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
            }

            if (t5.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4, T5, T6)> WhenAll<T1, T2, T3, T4, T5, T6>(ValueTask<T1> t1, ValueTask<T2> t2, ValueTask<T3> t3, ValueTask<T4> t4, ValueTask<T5> t5, ValueTask<T6> t6)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        if (t4.IsCompletedSuccessfully)
                        {
                            if (t5.IsCompletedSuccessfully)
                            {
                                if (t6.IsCompletedSuccessfully)
                                {
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                                }

                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, await t6.ConfigureAwait(false));
                            }

                            if (t6.IsCompletedSuccessfully)
                            {
                                return (t1.Result, t2.Result, t3.Result, t4.Result, await t5.ConfigureAwait(false), t6.Result);
                            }

                            await Task.WhenAll(t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                return (t1.Result, t2.Result, t3.Result, await t4.ConfigureAwait(false), t5.Result, t6.Result);
                            }

                            await Task.WhenAll(t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                return (t1.Result, t2.Result, await t3.ConfigureAwait(false), t4.Result, t5.Result, t6.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                return (t1.Result, await t2.ConfigureAwait(false), t3.Result, t4.Result, t5.Result, t6.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                return (await t1.ConfigureAwait(false), t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
            }

            if (t3.IsCompletedSuccessfully)
            {
                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
            }

            if (t4.IsCompletedSuccessfully)
            {
                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
            }

            if (t5.IsCompletedSuccessfully)
            {
                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
            }

            if (t6.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7)> WhenAll<T1, T2, T3, T4, T5, T6, T7>(ValueTask<T1> t1, ValueTask<T2> t2, ValueTask<T3> t3, ValueTask<T4> t4, ValueTask<T5> t5, ValueTask<T6> t6, ValueTask<T7> t7)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        if (t4.IsCompletedSuccessfully)
                        {
                            if (t5.IsCompletedSuccessfully)
                            {
                                if (t6.IsCompletedSuccessfully)
                                {
                                    if (t7.IsCompletedSuccessfully)
                                    {
                                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                                    }

                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, await t7.ConfigureAwait(false));
                                }

                                if (t7.IsCompletedSuccessfully)
                                {
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, await t6.ConfigureAwait(false), t7.Result);
                                }

                                await Task.WhenAll(t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, await t5.ConfigureAwait(false), t6.Result, t7.Result);
                                }

                                await Task.WhenAll(t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    return (t1.Result, t2.Result, t3.Result, await t4.ConfigureAwait(false), t5.Result, t6.Result, t7.Result);
                                }

                                await Task.WhenAll(t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    return (t1.Result, t2.Result, await t3.ConfigureAwait(false), t4.Result, t5.Result, t6.Result, t7.Result);
                                }

                                await Task.WhenAll(t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    return (t1.Result, await t2.ConfigureAwait(false), t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                                }

                                await Task.WhenAll(t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    return (await t1.ConfigureAwait(false), t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                                }

                                await Task.WhenAll(t1.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
            }

            if (t3.IsCompletedSuccessfully)
            {
                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
            }

            if (t4.IsCompletedSuccessfully)
            {
                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
            }

            if (t5.IsCompletedSuccessfully)
            {
                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
            }

            if (t6.IsCompletedSuccessfully)
            {
                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
            }

            if (t7.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result);
        }

        public static async ValueTask<(T1, T2, T3, T4, T5, T6, T7, T8)> WhenAll<T1, T2, T3, T4, T5, T6, T7, T8>(ValueTask<T1> t1, ValueTask<T2> t2, ValueTask<T3> t3, ValueTask<T4> t4, ValueTask<T5> t5, ValueTask<T6> t6, ValueTask<T7> t7, ValueTask<T8> t8)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        if (t4.IsCompletedSuccessfully)
                        {
                            if (t5.IsCompletedSuccessfully)
                            {
                                if (t6.IsCompletedSuccessfully)
                                {
                                    if (t7.IsCompletedSuccessfully)
                                    {
                                        if (t8.IsCompletedSuccessfully)
                                        {
                                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                        }

                                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, await t8.ConfigureAwait(false));
                                    }

                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, await t7.ConfigureAwait(false), t8.Result);
                                    }

                                    await Task.WhenAll(t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, await t6.ConfigureAwait(false), t7.Result, t8.Result);
                                    }

                                    await Task.WhenAll(t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        return (t1.Result, t2.Result, t3.Result, t4.Result, await t5.ConfigureAwait(false), t6.Result, t7.Result, t8.Result);
                                    }

                                    await Task.WhenAll(t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        return (t1.Result, t2.Result, t3.Result, await t4.ConfigureAwait(false), t5.Result, t6.Result, t7.Result, t8.Result);
                                    }

                                    await Task.WhenAll(t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        return (t1.Result, t2.Result, await t3.ConfigureAwait(false), t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                    }

                                    await Task.WhenAll(t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        return (t1.Result, await t2.ConfigureAwait(false), t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                    }

                                    await Task.WhenAll(t2.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t2.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t2.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t2.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        return (await t1.ConfigureAwait(false), t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                    }

                                    await Task.WhenAll(t1.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t1.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t1.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t1.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            if (t3.IsCompletedSuccessfully)
            {
                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                                }

                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            if (t4.IsCompletedSuccessfully)
            {
                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            if (t5.IsCompletedSuccessfully)
            {
                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            if (t6.IsCompletedSuccessfully)
            {
                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            if (t7.IsCompletedSuccessfully)
            {
                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            if (t8.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
            return (t1.Result, t2.Result, t3.Result, t4.Result, t5.Result, t6.Result, t7.Result, t8.Result);
        }
    }
}
