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

![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/62f77d17-186f-4c9c-82f4-c6e334081819)

Количество эпох зависит от сложности решаемой операции и от степени изменения весов.

## Задание 3
### Визуализировать работу персептрона с помощью физуальной модели на сцене Unity.

Ход работы:
- Созать сцену в Unity c 8 кубами белого (1) и черного (0) цветов.

Сцена до:

![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/9581cfee-f938-4071-8dbb-afab7a01302f)


Сцена OR:

![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/25256383-c73f-4d56-a38f-f25e61718f27)


Сцена AND:

![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/3f59573f-1cca-49b2-9a1c-d5cbeed9ca5d)


Сцена NAND:

![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/9259da4c-1887-4aa6-958d-f4e4922aa1b1)


Сцена XOR:

![image](https://github.com/AlinaBasyrova/DA_in_GameDev_4/assets/129521982/af9bc971-e14c-4848-80bb-6866262d3f56)

## Выводы
- В ходе лабораторной работы я познакомилась с перцептроном, научилась работать с ним в Unity на примере простейших логических операций (AND, OR, NAND, XOR), реализовала визуализацию этих логических операций с помощью кубиков.


| Plugin | README |
| ------ | ------ |
| GitHub | [plugins/github/README.md][PlGh] |
| Visual Studio| [plugins/visualstudio/README.md][PlGh] |
| Unity | [plugins/unity/README.md][PlMe] |

## Powered by

**BigDigital Team: Denisov | Fadeev | Panov**
