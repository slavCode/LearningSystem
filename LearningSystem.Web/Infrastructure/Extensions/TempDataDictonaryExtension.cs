namespace LearningSystem.Web.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Mvc.ViewFeatures;

    using static Core.GlobalConstants;

    public static class TempDataDictonaryExtension
    {
        public static void AddSuccessMessage(this ITempDataDictionary tempData, string message)
           => tempData[TempDataSuccessMessageKey] = message;

        public static void AddErrorMessage(this ITempDataDictionary tempData, string message)
           => tempData[TempDataErrorMessageKey] = message;
    }
}
