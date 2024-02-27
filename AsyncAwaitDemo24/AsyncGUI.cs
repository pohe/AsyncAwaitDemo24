﻿// See https://aka.ms/new-console-template for more information
public class AsyncGUI
{
    public AsyncBackEnd AsyncBackEnd { get; set; }
    public AsyncGUI()
    {
        AsyncBackEnd = new AsyncBackEnd();
    }

    public async void HandleButtonClickAsync()
    {
        Console.WriteLine("Started HandleButtonClickAsync");

        await AsyncBackEnd.DoTaskA_Async();
        Console.WriteLine("Ended  DoTaskAUpdated");
        await AsyncBackEnd.DoTaskB_Async();
        Console.WriteLine("Ended  DoTaskBUpdated");

        #region alternativ kald af asynkron metode
        //To måder at kalde asyncront når der returneres en værdi

        //Task<int> t = AsyncBackEnd.DoTaskC_Async();
        //await t;
        //int result = t.Result;

        #endregion

        int result = await AsyncBackEnd.DoTaskC_Async();
        Console.WriteLine("Ended  DoTaskCUpdated");
        Console.WriteLine($"I got {result} from DoTaskC()");

        Console.WriteLine("All done HandleButtonClickAsync");
    }

}