using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

struct Transaction
{
    // 交易時間
    public TimeSpan Time { get; set; }
    // 交易描述
    public string Desc { get; set; }
    // 交易額
    public int Amount { get; set; }
    // 收入或支出
    public TransactionType Type { get; set; }
    // 標籤
    public TransactionTag Tag { get; set; }
}

enum TransactionType
{
    INCOME,
    OUTCOME
}

enum TransactionTag
{
    FOOD,
    TRANSPORTATION,
    ENTERTAINMENT,
    DAILY,
    OTHER
}

class TransactionManager
{
    // 當日日期
    public DateTime Date { get; set; }
    // 紀錄當日交易
    public List<Transaction> Transactions { get; set; }

    public TransactionManager()
    {
        this.Date = DateTime.Now;
        this.Transactions = new List<Transaction>();
    }

    // 排序交易 cmp可選{"time","desc","amount","type","tag"}
    public static void Sort(List<Transaction> transactions, string cmp)
    {
        switch (cmp)
        {
            case "time":
                transactions.Sort((x, y) => x.Time.CompareTo(y.Time));
                break;
            case "desc":
                transactions.Sort((x, y) => x.Desc.CompareTo(y.Desc));
                break;
            case "amount":
                transactions.Sort((x, y) => x.Amount.CompareTo(y.Amount));
                break;
            case "type":
                transactions.Sort((x, y) => x.Type.CompareTo(y.Type));
                break;
            case "tag":
                transactions.Sort((x, y) => x.Tag.CompareTo(y.Tag));
                break;
        }
    }

    // 排序當日交易
    public void Sort(string cmp) { Sort(this.Transactions, cmp); }

    // 過濾交易 收入/支出
    public static List<Transaction> Filter(List<Transaction> transactions, TransactionType type)
    {
        return transactions.FindAll(t => t.Type == type);
    }

    // 過濾交易標籤
    public static List<Transaction> Filter(List<Transaction> transactions, TransactionTag tag)
    {
        return transactions.FindAll(t => t.Tag == tag);
    }

    // 過濾當日交易 收入/支出
    public List<Transaction> Filter(TransactionType type) { return Filter(this.Transactions, type); }
    // 過濾當日交易標籤

    public List<Transaction> Filter(TransactionTag tag) { return Filter(this.Transactions, tag); }



    // 新增交易
    public void AppendTransaction(Transaction trans)
    {
        this.Transactions.Add(trans);
    }

    public void DeleteTransaction(Transaction trans)
    {
        this.Transactions.Remove(trans);
    }

    static private string LoadDate(string date)
    {
        string json;

        if (File.Exists("./data/" + date + ".json"))
        {
            json = File.ReadAllText("./data/" + date + ".json");
        }
        else
        {
            throw new FileNotFoundException($"Cant't not find ./data/{date}.json");
        }

        return json;
    }

    public bool SaveDate(DateTime date)
    {
        try
        {
            string json = JsonConvert.SerializeObject(this.Transactions, Formatting.Indented);
            File.WriteAllText("./data/" + date.ToString("yyyy_MM_dd") + ".json", json);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool ChangeDate(DateTime date)
    {
        if (this.Transactions.Count > 0)
        {
            SaveDate(this.Date);
        }

        this.Date = date;

        try
        {
            string json = LoadDate(date.ToString("yyyy_MM_dd"));
            this.Transactions = JsonConvert.DeserializeObject<List<Transaction>>(json);

            return true;
        }
        catch
        {
            this.Transactions = new List<Transaction>();

            return false;
        }
    }
}
