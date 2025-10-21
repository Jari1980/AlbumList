# AlbumList

<p>Minimal API, working as ordinary API but without a Controller. The API performs basic CRUD operations for a album database, when API is launched it will check if db table Album is empty, if so some initial albums will be seeded.</p>
<p>The API is connected to local MSSQL, SQLEXPRESS, if you want other connection the connectionstring needs to be changed in appsetting.json.</p>
<p>In order to create AlbumDb with table Album you can write "update-database" in Package Manager Console which should create all according to latest migration.</p>
<p>Packages used are:</p>
<li>Microsoft.EntityFrameworkCore</li>
<li>Microsoft.EntityFrameworkCore.SqlServer</li>
<li>Microsoft.EntityFrameworkCore.Tools</li>
