using StatisticsCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StatisticsCalculator
{
    public class StatCalc
    {
        //Interner Speicher des Rechners
        private List<int> _numbers;

        //-----Basisfunktionalitäten

        //Initialisiert den Statistikrechner ohne Zahlen
        public StatCalc()
        {
            _numbers = new List<int>();
        }

        //Initialisiert den Statistikrechner mit den angegebenen Zahlen
        public StatCalc(int[] initialNumbers)
        {
            _numbers = new List<int>(initialNumbers);
        }

        //Gibt eine Kopie des internen Speichers zurück
        public int[] GetNumbers()
        {
            return _numbers.ToArray();
        }

        //Die Methode AddNumber fügt eine Zahl zum internen Speicher hinzu
        public void AddNumber(int number)
        {
            _numbers.Add(number);
        }

        //Die Methode ClearNumbers löscht alle Zahlen aus dem internen Speicher
        public void ClearNumbers()
        {
            _numbers.Clear();
        }

        //Die Methode RemoveLastNumber entfernt die zuletzt hinzugefügte Zahl - oder macht nichts, falls keine Zahl enthalten ist
        public void RemoveLastNumber()
        {
            if (_numbers.Count > 0)
            {
                _numbers.RemoveAt(_numbers.Count - 1);
            }
        }

        //-----Berechnungsmethoden

        //Der Durchschnitt einer Menge von Zahlen wird berechnet indem die Summe aller Zahlen durch die Anzahl der Zahlen dividiert wird
        //zB der Durchschnitt von 4, 3, 8 beträgt 5
        //Der Durchschnitt von keinen Zahlen ist nicht definiert
        //Der Durchschnitt einer Zahl ist die Zahl selbst

        //Die Methode CalculateAverage berechnet den Durchschnitt aller Zahlen die in _numbers gespeichert sind
        //Wenn keine Zahlen in _numbers gespeichert sind, soll eine AverageCalculationException geworfen

        public decimal CalculateAverage()
        {
            if (_numbers.Count == 0)
            {
                throw new AverageCalculationException();
            }

            decimal sum = 0;
            for (int i = 0; i < _numbers.Count; i++)
            {
                sum += _numbers[i];
            }
            return sum / _numbers.Count;
        }

        //Der Modus einer Menge von Zahlen gibt an, welche Zahl am häufigsten vorgekommen ist
        //zB der Modus von 1, 5, 2, 3, 1, 8, 9, 3, 1 beträgt 1 (da 1 am häufigsten vorkommt)
        //Eine Menge an Zahlen kann Theoretisch mehr als einen Modus haben:
        //zum Beispiel für 1, 4, 3, 4, 4, 1, 1 beträgt 1 und 4 (da beide am gleich-häufigsten vorgekommen sind)
        //Gibt es in einer Menge von Zahlen keine Zahlen die sich wiederholen so ist der Modus nicht definiert
        //Der Modus von einer Zahl ist die Zahl selbst

        //Die Methode GetSingleMode soll für alle Zahlen die in _numbers gespeichert sind, einen Modus finden
        //Sind keine Zahlen in _numbers gespeichert, soll eine InvalidModeCalculation Exception geworfen werden
        //Gibt es keinen oder mehr als einen Modus, soll eine SingleModeNotFound Exception geworfen werden

        public int GetSingleMode()
        {
            var countingMap = new Dictionary<int, int>();

            if (_numbers.Count == 0)
            {
                throw new InvalidModeCalculationException();
            }

            foreach (var number in _numbers)
            {
                if (countingMap.ContainsKey(number))
                {
                    countingMap[number] += 1;
                }
                else
                {
                    countingMap[number] = 1;
                }
            }

            var maxCount = countingMap.Max(kvp => kvp.Value);

            var modes = countingMap.Where(kvp => kvp.Value == maxCount);

            if (modes.Count() != 1)
            {
                throw new SingleModeNotFoundException();
            }

            return modes.First().Key;
        }
    }
}
