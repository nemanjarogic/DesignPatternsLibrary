using CompositeLibrary.ShareholdersExample.After;
using CompositeLibrary.ShareholdersExample.Before;

namespace CompositeLibrary.ShareholdersExample
{
    public static class ShareholdersExecutor
    {
        public static void Execute()
        {
            BeforeExecutor.Execute();
            AfterExecutor.Execute();
        }
    }
}
