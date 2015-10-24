namespace ProjectTemplate.Core.Repository
{
    public class MappingHelper
    {
        //ToDo: Will be taken from config.

        private static bool isFetchValueSelect = false;

        public static bool IsFetchValueSelect
        {
            get { return isFetchValueSelect; }
        }
    }
}
