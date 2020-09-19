<h3>Задание 8. 
<h4>Комплексные вычисления (Reflection, dynamic)</h4>
<h4>1. Если в каталоге программы присутствует сборка из домашнего задания 2.1 (комплексные числа), то, используя Reflection и эту сборку, необходимо: </h4>
Не используя dynamic, вычислить значение выражения:
<h5>z=((𝑥 + 𝑦)^2)/27, где 𝑥 = 2 + 3𝑖; 𝑦 = 14(cos (𝜋/4) + 𝑖sin(𝜋/4))</h5>
* Т.е. одно комплексное число задано в обычном виде, а второе в тригонометрическом
<br> Распечатать результат в обычном виде и в виде модуля и аргумента (тригонометрическом виде)
<p>
<p> Используя dynamic, вычислить:
<h5> 𝑐 = ((𝑎^2 + 𝑏^2)^2)/3𝑏 ,где 𝑎 = 4 + 𝑖; 𝑏 = 2(cos (𝜋/3) + 𝑖sin(𝜋/3))</h5>
* Т.е. одно комплексное число задано в обычном виде, а второе в тригонометрическом
<br> Распечатать результат в обычном виде и в виде модуля и аргумента (тригонометрическом виде)
<p>
<h4>2. Если в каталоге программы отсутствует сборка из домашнего задания 2.1, то: </h4>
Необходимо сообщить об этом пользователю
<p> Используя стандартную .NET структуру System.Numerics.Complex, без
Reflection, вычислить:
<h5>𝑑=34+𝑒^𝑓 ,где 𝑒 =1+2𝑖; 𝑓 =3(cos(𝜋/8)+𝑖sin(𝜋/8))</h5>
* При этом Complex уже обладает всеми необходимыми методами для работы с
комплексными числами, например, FromPolarCoordinates(), Pow() и т.д.
<br> Вывести результат пользователю