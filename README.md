# АНАЛИЗ ДАННЫХ И ИСКУССТВЕННЫЙ ИНТЕЛЛЕКТ [in GameDev]
Отчет по лабораторной работе #4 выполнил(а):
- Басырова Алина Радмировна
- РИ220942
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 60 |
| Задание 2 | * | 20 |
| Задание 3 | * | 20 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета
- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- В проекте реализовать персептрон, который умеет производить вычисления: OR, AND, NAND, XOR, и дать комментарии о кореектности работы.
- Задание 2.
- Построить графики зависимости количества эпох от ошибки обучения. Указать, от чего зависит необходимое количество эпох обучения.
- Задание 3.
- Визуализировать работу персептрона с помощью физуальной модели на сцене Unity.
- Выводы.

## Цель работы
Познакомиться с работой персептрона на практике при помощи движка Unity. Реализовать персептрон, который умеет решать задачки на логические операции.

## Задание 1
### В проекте реализовать персептрон, который умеет производить вычисления: OR, AND, NAND, XOR, и дать комментарии о корректности работы (Дал комментарии в выводе к работе).

Ход работы:
- Создала новый проект в Unity. Создала в нем пустой объект и добавила к нему скрипт Perceptron.

### 1) OR (Логическое сложение(ИЛИ)):
- Таблица истинности:
 
| A | B | A OR B |
|-- |-- | ------ |
| 0 | 0 | 0 |
| 0 | 1 | 1 |
| 1 | 0 | 1 |
| 1 | 1 | 1 |

Задала необходимые значения и запустила перцептрон. Для наглядности оставила только вывод номера эпохи и колиечство ошибок. В результате через 3-4 поколения перцептрон перестает совершать ошибки, а следовательно успешно обучился.

![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/7cb0113a-0e10-4465-8762-55046b021d5a)
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/b150f040-fe7b-41c2-b46a-0048c1400e84)
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/3f62bc9b-011a-4755-872c-6eefcb963aba)

Тоже самое проделываем с остальными логическими операциями.

### 2) AND (Логическое умножение(И)):
- Таблица истинности:
 
| A | B | A AND B |
|-- |-- | ------ |
| 0 | 0 | 0 |
| 0 | 1 | 0 |
| 1 | 0 | 0 |
| 1 | 1 | 1 |

Перцептрон обучается в среднем через 5 поколений.
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/23f41719-6c6f-4f23-88a3-207a51ec0f0a)
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/1977fe05-aeb6-4cd0-a7ad-732d29aee432)


### 3) NAND (Инвертированное Логическое умножение(НЕ И)):
- Таблица истиснности:
 
| A | B | A NAND B |
|-- |-- | ------ |
| 0 | 0 | 1 |
| 0 | 1 | 1 |
| 1 | 0 | 1 |
| 1 | 1 | 0 |

Перцептрон обучается в среднем через 5-6 поколений.
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/0f6ac575-f781-479d-afcf-6010dfa71990)
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/add48564-d8bf-4642-8ff6-fb5226d04d0e)


### 4) XOR (Исключающая Логическая сумма((ИЛИ) и (НЕ И))):
- Таблица истинности:
 
| A | B | A XOR B |
|-- |-- | ------ |
| 0 | 0 | 0 |
| 0 | 1 | 1 |
| 1 | 0 | 1 |
| 1 | 1 | 0 |

Не зависимо от количества поколений перцептрон так и не смог обучиться.
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/807dd102-350f-4d19-9b78-0d5e5872b74d)
![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/872877d4-c075-427c-83a7-5d917de32ded)


## Задание 2
### Построить графики зависимости количества эпох от ошибки обучения. Указать, от чего зависит необходимое количество эпох обучения (Указал в выводе к работе).

Ход работы:
- Заполнить Google-Таблицу данными об эпохах и визуализировать их с помощью графиков (проделать для каждой логической операции, разобранной в первом задании).

В данной работе для каждой операции я делал 5 попыток с 8-ю эпохами обучения. На графиках указано среднее значение Total Error за 5 попыток.
### OR (Логическое сложение(ИЛИ)):
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/d6e3acad-a83b-4f35-9e18-b98aad124cdc)

### AND (Логическое умножение(И)):
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/030731a8-e15f-4f50-95f5-0f4bfd23cf3a)

### NAND (Инвертированное Логическое умножение(НЕ И)):
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/2e95c306-8c02-4b46-9905-a218a52c3ad0)

### XOR (Исключающая Логическая сумма((ИЛИ) и (НЕ И))):
У данной операции для получения количества ошибок я складывал количество ошибок при каждой операции (сумма ошибок на первой эпохе обучения в каждой операции и так для всех эпох обучения)
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/412c9e69-f277-4148-ac37-43be86de5556)


Количество эпох обучения зависит от решаемой операции. Например при операции OR ошибок не встречается уже на пятой эпохе обучения, при AND и NAND - при седьмой, при XOR - при восьмой. Статистика не совсем точная, так как взято небольшое количество попыток, всего 5.

## Задание 3
### Визуализировать работу персептрона с помощью физуальной модели на сцене Unity.
Ход работы:
- Создать сцену в Unity, добавить несколько кубов, плоскость(сделал фиолетовую, т.к. мой любимый цвет, не судите строго) и визуализировать каждую логическую операцию.
- Для начала я создал сцену с тремя вариантами возможными вариантами, в которой черный куб симвализирует 0 (Ложь), а белый - 1 (Истина); возможно всего три варианта пар значений: (0 0), (0 1)/(1 0) и (1 1).
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/f5d0c9a1-7973-4045-b6cd-913138e46b42)

При столкновении кубов, они оба должны окраситься в цвет результата той или иной операции (напомню, черный цвет означает 0 (Ложь), а белый - 1 (Истина)).

Для этого в коде я завел две новые переменные, которые будут отвечать за значение, которое представляет собой куб (0 или 1). И уже эти значения нужно будет подставлять в функцию CalcOutput для определения результата операции после обучения модели. Также у верхнего куба нужно назначить Rigidbody, а у нижнего - Is trigger. поэтому старый код немного поменялся, вот новый код:

```C#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TrainingSet
{
	public double[] input;
	public double output;
}


public class Perceptron : MonoBehaviour {
	// public TrainingSet[] tsOR;
	// public TrainingSet[] tsNAND;
	public TrainingSet[] ts;

	public double firstCube;
	public double secondCube;
	double[] weights = {0,0};
	double bias = 0;
	double totalError = 0;

	double DotProductBias(double[] v1, double[] v2) 
	{
		if (v1 == null || v2 == null)
			return -1;
	 
		if (v1.Length != v2.Length)
			return -1;
	 
		double d = 0;
		for (int x = 0; x < v1.Length; x++)
		{
			d += v1[x] * v2[x];
		}

		d += bias;
	 
		return d;
	}

	double CalcOutput(int i, TrainingSet[] set)
	{
		double dp = DotProductBias(weights,set[i].input);
		if(dp > 0) return(1);
		return (0);
	}

	void InitialiseWeights()
	{
		for(int i = 0; i < weights.Length; i++)
		{
			weights[i] = Random.Range(-1.0f,1.0f);
		}
		bias = Random.Range(-1.0f,1.0f);
	}

	void UpdateWeights(int j, TrainingSet[] set)
	{
		double error = set[j].output - CalcOutput(j, set);
		totalError += Mathf.Abs((float)error);
		for(int i = 0; i < weights.Length; i++)
		{			
			weights[i] = weights[i] + error * set[j].input[i]; 
		}
		bias += error;
	}

	double CalcOutput(double i1, double i2)
	{
		double[] inp = new double[] {i1, i2};
		double dp = DotProductBias(weights,inp);
		if(dp > 0) return(1);
		return (0);
	}

	void Train(int epochs, TrainingSet[] set)
	{
		InitialiseWeights();
		
		for(int e = 0; e < epochs; e++)
		{
			totalError = 0;
			for(int t = 0; t < set.Length; t++)
			{
				UpdateWeights(t, set);
				Debug.Log("W1: " + (weights[0]) + " W2: " + (weights[1]) + " B: " + bias);
			}
			Debug.Log("TOTAL ERROR: " + totalError);
		}
	}

	void Start () {
		// Train(8, tsOR);
		// double tsOr0 = CalcOutput(0,0); //0
		// double tsOr1 = CalcOutput(0,1); //1
		// double tsOr2 = CalcOutput(1,0); //1
		// double tsOr3 = CalcOutput(1,1); //1
		
		// Train(8, tsNAND);
		// double tsNAND0 = CalcOutput(0,0); //1
		// double tsNAND1 = CalcOutput(0,1); //1
		// double tsNAND2 = CalcOutput(1,0); //1
		// double tsNAND3 = CalcOutput(1,1); //0
		Train(8, ts);
	}
	
	void Update () {
		
	}
	private void OnTriggerEnter(Collider other) {
		if (CalcOutput(firstCube, secondCube) == 0) {
			other.gameObject.GetComponent<Renderer>().material.color = Color.black;
        	this.gameObject.GetComponent<Renderer>().material.color = Color.black;
		}
		else {
			other.gameObject.GetComponent<Renderer>().material.color = Color.white;
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
		}
    }
}

```
### OR (Логическое сложение(ИЛИ)):
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/6409610f-2729-41f5-8c3b-9d7dad0fcaaa)

- Результат:
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/2ebc2721-951b-4b4e-8618-0025b91a07e9)
- Процесс выполнения:
![OR](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/ac5e1d3f-6cbe-44e3-a0aa-22668930cc1f)




### AND (Логическое умножение(И)):
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/f5d0c9a1-7973-4045-b6cd-913138e46b42)

- Результат:
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/0fb4853e-3e4e-4f4a-892b-835ea6a8c2e7)
- Процесс выполнения:
![203351408-9844174f-4b46-4eed-9e82-bceece979c1a](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/0f123e5e-d264-4f4c-a8cf-bfaf1fb74056)




### NAND (Инвертированное Логическое умножение(НЕ И)):
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/f5d0c9a1-7973-4045-b6cd-913138e46b42)

- Результат:
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/2642eaa8-fc3a-4105-8486-2b5c7d4347c7)
- Процесс выполнения:
![NAND](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/f7e5be35-887b-4574-8f21-9067cefc3228)




### XOR (Исключающая Логическая сумма((ИЛИ) и (НЕ И))):
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/f5d0c9a1-7973-4045-b6cd-913138e46b42)

- Результат:
![image](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/5dc84337-963c-4254-ac9d-5e2d90f858a4)
- Процесс выполнения:
![XOR](https://github.com/Yeager07/DA-in-GameDev-lab1/assets/127008112/9640483d-b80c-4125-b7ce-ef780131cc2d)




## Выводы
- В ходе данной лабороторной работы я познакомился с моделью нейронной сети - персептроном. С помощью однослойного персептрона смог реализовать такие логические операции, как: OR, AND, NAND. Для операции XOR мне пришлось применять три персептрона, каждый из которых выполнял одну из операций упомянутых ранее. Из этого я сделал вывод, что однослойный персептрон способен решать только линейные задачи. Также построил графики на основе количества ошибок при каждой эпохе обучения, чтобы оценить обучаемость модели для той или иной операции: выяснил, что легче всего персептрону далась операция OR (видно из графика). Выяснил, что количество эпох обучения зависит от решаемой операции. Например при операции OR ошибок не встречается уже на пятой эпохе обучения, при AND и NAND - на седьмой, при XOR - на восьмой. Статистика не совсем точная, так как взято небольшое количество попыток, всего 5, а также, применив функционал Unity, построил наглядную модель работы персептрона: при столкновении кубов выполнялась та или иная логическая операция и они окрашивались в цвет её результата (более подробно описал в 3 задании).


| Plugin | README |
| ------ | ------ |
| GitHub | [plugins/github/README.md][PlGh] |
| Visual Studio| [plugins/visualstudio/README.md][PlGh] |
| Unity | [plugins/unity/README.md][PlMe] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
