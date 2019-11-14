# xl2md
A tool for turning Excel workbooks into Reddit table markdown

This tool takes an Excel workbook and will create text files containing Reddit markdown which will format the data as a Reddit table.

Each worksheet in the workbook will be converted to its own text file.

If you want xl2md to ignore a specific worksheet, set the first character of the worksheet to be an underscore ("_").

xl2md assumes that the first row on a worksheet has column headers.  If you want xl2md to ignore a specific column on a worksheet, set the first character of the column header to be an underscore ("_").

For best results, remove any blank columns or rows from your worksheets.  xl2md interprets empty rows or columns as the end of your data.

xl2md uses the excellent EPPLus library (https://github.com/JanKallman/EPPlus) which allows access to Excel workbooks without requiring any Microsoft Office components.
