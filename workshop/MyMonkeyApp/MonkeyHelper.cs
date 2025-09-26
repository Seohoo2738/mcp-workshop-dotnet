using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Monkey 데이터 관리를 위한 정적 헬퍼 클래스
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey { Name = "Capuchin", Location = "South America", Population = 50000, AsciiArt = "(\"._.\")" },
        new Monkey { Name = "Mandrill", Location = "Africa", Population = 10000, AsciiArt = "(o.o)" },
        new Monkey { Name = "Japanese Macaque", Location = "Japan", Population = 30000, AsciiArt = "(='.'=)" }
    };

    private static int randomPickCount = 0;

    /// <summary>
    /// 모든 원숭이 목록 반환
    /// </summary>
    public static List<Monkey> GetMonkeys() => monkeys;

    /// <summary>
    /// 이름으로 원숭이 찾기
    /// </summary>
    public static Monkey? GetMonkeyByName(string name)
    {
        return monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// 랜덤 원숭이 반환 및 선택 횟수 증가
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        var rand = new Random();
        randomPickCount++;
        return monkeys[rand.Next(monkeys.Count)];
    }

    /// <summary>
    /// 랜덤 선택 횟수 반환
    /// </summary>
    public static int GetRandomPickCount() => randomPickCount;
}
