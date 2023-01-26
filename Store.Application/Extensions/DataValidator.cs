namespace Store.Application.Extensions
{
    public class DataValidator
    {
        /// <summary>
        /// Verifica se o <paramref name="content"/> é maior ou igual do que <paramref name="lenght"/>
        /// </summary>
        /// <param name="content"></param>
        /// <param name="lenght"></param>
        /// <returns>
        ///     Retorna <see langword="true"/> se for maior, senão <see langword="false"/>
        /// </returns>
        public static bool IsGreaterOrEqual(string content, int lenght)
        {
            if (content.Length >= lenght)
                return true;

            return false;
        }

        /// <summary>
        /// Verifica se o <paramref name="content"/> é menor ou igual do que <paramref name="lenght"/>
        /// </summary>
        /// <param name="content"></param>
        /// <param name="lenght"></param>
        /// <returns>
        ///     Retorna <see langword="true"/> se for menor, senão <see langword="false"/>
        /// </returns>
        public static bool IsLessOrEqual(string content, int lenght)
        {
            if (content.Length <= lenght)
                return true;

            return false;
        }

    }
}