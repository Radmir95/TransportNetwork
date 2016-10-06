using System;
using System.Data;

namespace TransportNetwork.DataAccessLayer.XMLRepository
{
    public class XMLWriter
    {

        public void WriteInXMLFile()
        {

            var ds = new DataSet();
            // создаем таблицу чеков
            var chek = new DataTable("Чеки");
            // добавляем таблицу в список таблиц набора данных
            ds.Tables.Add(chek);
            // формируем список столбцов таблицы чеков
            // для каждого столбца указывается имя столбца и тип данных
            // атрибут номера чека
            var dc = new DataColumn("НомерЧека",
            Type.GetType("System.Int32"));
            ds.Tables["Чеки"].Columns.Add(dc);
            // атрибут даты чека
            dc = new DataColumn("ДатаЧека", Type.GetType("System.DateTime"));
            ds.Tables["Чеки"].Columns.Add(dc);
            // атрибут названия магазина
            dc = new DataColumn("Магазин", Type.GetType("System.String"));
            ds.Tables["Чеки"].Columns.Add(dc);
            // атрибут ФИОКассира
            dc = new DataColumn("ФИОКассира", Type.GetType("System.String"));
            ds.Tables["Чеки"].Columns.Add(dc);
            // атрибут общей стоимости чека
            dc = new DataColumn("ОбщаяСтоимость",
            Type.GetType("System.Int32"));
            ds.Tables["Чеки"].Columns.Add(dc);

            var key = new DataColumn[2]
{ ds.Tables["Чеки"].Columns["НомерЧека"],
ds.Tables["Чеки"].Columns["ДатаЧека"] };
            ds.Tables["Чеки"].PrimaryKey = key;
            // создаем таблицу записей чеков
            // добавляем таблицу в список таблиц набора данных
            ds.Tables.Add(new DataTable("ЗаписьЧека"));
            // атрибут номера записи чека
            dc = new DataColumn("НомерЗаписиЧека",
            Type.GetType("System.Int32"));

ds.Tables["ЗаписьЧека"].Columns.Add(dc);
            // атрибут номера чека
            dc = new DataColumn("НомерЧека", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);
            // атрибут даты чека
            dc = new DataColumn("ДатаЧека", Type.GetType("System.DateTime"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);
            // атрибут название товара
            dc = new DataColumn("Товар", Type.GetType("System.String"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);
            // атрибут цены товара
            dc = new DataColumn("ЦенаТовара", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);
            // атрибут количества товара
            dc = new DataColumn("Количество", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);
            // атрибут общей стоимости строки
            dc = new DataColumn("Стоимость", Type.GetType("System.Int32"));
            ds.Tables["ЗаписьЧека"].Columns.Add(dc);
            // описание первичного ключа - массива ссылок на столбцы таблицы
            // первичным ключом будет номер записи чека
            key = new DataColumn[3]
            { ds.Tables["ЗаписьЧека"].Columns["НомерЗаписиЧека"],
ds.Tables["ЗаписьЧека"].Columns["НомерЧека"],
ds.Tables["ЗаписьЧека"].Columns["ДатаЧека"] };
            ds.Tables["ЗаписьЧека"].PrimaryKey = key;
            // создание связи между таблицами
            // указывается имя отношения и два массива связанных полей –
            // для родительской и дочерней таблиц
            var rel = new DataRelation("СвязьЧека",
            new []{ds.Tables["Чеки"].Columns["НомерЧека"],
ds.Tables["Чеки"].Columns["ДатаЧека"]},
            new []{ds.Tables["ЗаписьЧека"].Columns["НомерЧека"],
ds.Tables["ЗаписьЧека"].Columns["ДатаЧека"]});
            //добавляем связь в список связей набора данных
            ds.Relations.Add(rel);

            var newrow = ds.Tables["Чеки"].NewRow();
            // заполнение атрибутов чека
            // для определения номера чека можно узнать количество строк
            // в таблице чеков
            // например, если в таблице 5 чеков, то номер вновь
            // созданного чека должен быть 6
            newrow["НомерЧека"] = ds.Tables["Чеки"].Rows.Count + 1;
            // запоминаем номер чека
            var nom = (int)newrow["НомерЧека"];
            newrow["ДатаЧека"] = DateTime.Today;
            // запоминаем дату чека
            var date = (DateTime)newrow["ДатаЧека"];
            newrow["Магазин"] = "Магазин1";
            newrow["ФИОКассира"] = "Кассир1";
            // пока не введены данные о записях чека, общая стоимость равна 0
            newrow["ОбщаяСтоимость"] = 0;
            // записываем созданную запись в таблицу
            ds.Tables["Чеки"].Rows.Add(newrow);

            ds.WriteXml("chek.xml", XmlWriteMode.WriteSchema);

        }

    }
}
