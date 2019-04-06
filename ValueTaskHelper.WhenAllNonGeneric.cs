using System;
using System.Threading.Tasks;

namespace ValueTaskHelpers
{
    public static partial class ValueTaskHelper
    {
        public static async ValueTask WhenAll(ValueTask t1, ValueTask t2)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    return;
                }

                await t2.ConfigureAwait(false);
                return;
            }

            if (t2.IsCompletedSuccessfully)
            {
                await t1.ConfigureAwait(false);
                return;
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
        }

        public static async ValueTask WhenAll(ValueTask t1, ValueTask t2, ValueTask t3)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        return;
                    }

                    await t3.ConfigureAwait(false);
                    return;
                }

                if (t3.IsCompletedSuccessfully)
                {
                    await t2.ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    await t1.ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t3.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                return;
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
        }

        public static async ValueTask WhenAll(ValueTask t1, ValueTask t2, ValueTask t3, ValueTask t4)
        {
            if (t1.IsCompletedSuccessfully)
            {
                if (t2.IsCompletedSuccessfully)
                {
                    if (t3.IsCompletedSuccessfully)
                    {
                        if (t4.IsCompletedSuccessfully)
                        {
                            return;
                        }

                        await t4.ConfigureAwait(false);
                        return;
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        await t3.ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        await t2.ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t4.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        await t1.ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t4.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t3.IsCompletedSuccessfully)
            {
                if (t4.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t4.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                return;
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
        }

        public static async ValueTask WhenAll(ValueTask t1, ValueTask t2, ValueTask t3, ValueTask t4, ValueTask t5)
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
                                return;
                            }

                            await t5.ConfigureAwait(false);
                            return;
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            await t4.ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            await t3.ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            await t2.ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t2.IsCompletedSuccessfully)
            {
                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            await t1.ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t3.IsCompletedSuccessfully)
            {
                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t4.IsCompletedSuccessfully)
            {
                if (t5.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t5.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                return;
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
        }

        public static async ValueTask WhenAll(ValueTask t1, ValueTask t2, ValueTask t3, ValueTask t4, ValueTask t5, ValueTask t6)
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
                                    return;
                                }

                                await t6.ConfigureAwait(false);
                                return;
                            }

                            if (t6.IsCompletedSuccessfully)
                            {
                                await t5.ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                await t4.ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                await t3.ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t3.IsCompletedSuccessfully)
                {
                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                await t2.ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return;
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
                                await t1.ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t4.IsCompletedSuccessfully)
                {
                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return;
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
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t4.IsCompletedSuccessfully)
            {
                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t5.IsCompletedSuccessfully)
            {
                if (t6.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t6.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                return;
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
        }

        public static async ValueTask WhenAll(ValueTask t1, ValueTask t2, ValueTask t3, ValueTask t4, ValueTask t5, ValueTask t6, ValueTask t7)
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
                                        return;
                                    }

                                    await t7.ConfigureAwait(false);
                                    return;
                                }

                                if (t7.IsCompletedSuccessfully)
                                {
                                    await t6.ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    await t5.ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    await t4.ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t4.IsCompletedSuccessfully)
                    {
                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    await t3.ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
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
                                    await t2.ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
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
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return;
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
                                    await t1.ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t1.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t5.IsCompletedSuccessfully)
                    {
                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
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
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return;
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
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t5.IsCompletedSuccessfully)
                {
                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return;
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
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t5.IsCompletedSuccessfully)
            {
                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t6.IsCompletedSuccessfully)
            {
                if (t7.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t7.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                return;
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
        }

        public static async ValueTask WhenAll(ValueTask t1, ValueTask t2, ValueTask t3, ValueTask t4, ValueTask t5, ValueTask t6, ValueTask t7, ValueTask t8)
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
                                            return;
                                        }

                                        await t8.ConfigureAwait(false);
                                        return;
                                    }

                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        await t7.ConfigureAwait(false);
                                        return;
                                    }

                                    await Task.WhenAll(t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        await t6.ConfigureAwait(false);
                                        return;
                                    }

                                    await Task.WhenAll(t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        await t5.ConfigureAwait(false);
                                        return;
                                    }

                                    await Task.WhenAll(t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t5.IsCompletedSuccessfully)
                        {
                            if (t6.IsCompletedSuccessfully)
                            {
                                if (t7.IsCompletedSuccessfully)
                                {
                                    if (t8.IsCompletedSuccessfully)
                                    {
                                        await t4.ConfigureAwait(false);
                                        return;
                                    }

                                    await Task.WhenAll(t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
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
                                        await t3.ConfigureAwait(false);
                                        return;
                                    }

                                    await Task.WhenAll(t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
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
                                    return;
                                }

                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
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
                                        await t2.ConfigureAwait(false);
                                        return;
                                    }

                                    await Task.WhenAll(t2.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t2.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t2.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t2.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
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
                                    return;
                                }

                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
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
                                    return;
                                }

                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
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
                                return;
                            }

                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return;
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
                                        await t1.ConfigureAwait(false);
                                        return;
                                    }

                                    await Task.WhenAll(t1.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t1.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t1.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t6.IsCompletedSuccessfully)
                        {
                            if (t7.IsCompletedSuccessfully)
                            {
                                if (t8.IsCompletedSuccessfully)
                                {
                                    await Task.WhenAll(t1.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                    return;
                                }

                                await Task.WhenAll(t1.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
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
                                    return;
                                }

                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
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
                                    return;
                                }

                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
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
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return;
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
                                    return;
                                }

                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t8.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t7.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t6.IsCompletedSuccessfully)
                    {
                        if (t7.IsCompletedSuccessfully)
                        {
                            if (t8.IsCompletedSuccessfully)
                            {
                                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask()).ConfigureAwait(false);
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
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
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return;
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
                                return;
                            }

                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t8.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t7.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t6.IsCompletedSuccessfully)
                {
                    if (t7.IsCompletedSuccessfully)
                    {
                        if (t8.IsCompletedSuccessfully)
                        {
                            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask()).ConfigureAwait(false);
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return;
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
                            return;
                        }

                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t8.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t6.IsCompletedSuccessfully)
            {
                if (t7.IsCompletedSuccessfully)
                {
                    if (t8.IsCompletedSuccessfully)
                    {
                        await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask()).ConfigureAwait(false);
                        return;
                    }

                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t8.AsTask()).ConfigureAwait(false);
                    return;
                }

                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t7.IsCompletedSuccessfully)
            {
                if (t8.IsCompletedSuccessfully)
                {
                    await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask()).ConfigureAwait(false);
                    return;
                }

                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t8.AsTask()).ConfigureAwait(false);
                return;
            }

            if (t8.IsCompletedSuccessfully)
            {
                await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask()).ConfigureAwait(false);
                return;
            }

            await Task.WhenAll(t1.AsTask(), t2.AsTask(), t3.AsTask(), t4.AsTask(), t5.AsTask(), t6.AsTask(), t7.AsTask(), t8.AsTask()).ConfigureAwait(false);
        }
    }
}