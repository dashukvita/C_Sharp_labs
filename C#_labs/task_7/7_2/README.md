<h4>Задача 7.2. Наблюдение за файловой системой (События, файлы, каталоги)</h4>
<p>Написать систему слежения за папкой, в которой содержатся файлы с кодом (*.cs). Система должна запускаться из консоли, в качестве параметра ей передается путь папки и имя лог- файла. Система должна реагировать на создание новых файлов с кодом, а также на изменение и удаление уже существующих, и должна заносить в лог-файл и выводить на консоль информацию об изменениях. Например:
<p>Date, Time:            Name:           Change Type:
<br>26 Sep 2007, 13:11    HelloWorld.cs   CREATED
<br>26 Sep 2007, 13:13    HelloWorld.cs   CHANGED
<br>26 Sep 2007, 13:15    HelloWorld.cs   DELETED
<p>Примечание: для слежения за работой файловой системы можно использовать класс FileSystemWatcher из System.IO. Для реакции на события в файловой системе можно использовать обработчики событий и механизм обработки событий .NET. При использовании FileSystemWatcher обратите, пожалуйста, внимание на время жизни экземпляра FileSystemWatcher, он не должен быть собран сборщиком мусора.
