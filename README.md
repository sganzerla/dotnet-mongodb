# dotnet-mongodb

<h4>Tecnologias</h4>
<ul>
  <li>.NET Core 2.2</li>
  <li>.NET Entity Core Framework</li>
  <li>MongoDB 4.0</li> 
  <li>Swagger API Document 5.0</li>
 </ul>

 <h4>Requisitos</h4>
 <ul>
  <li>.NET Core 2.2 (https://dotnet.microsoft.com/download/dotnet-core/2.2)</li> 
  <li>MongoDB (https://docs.mongodb.com/manual/installation/) </li>
 </ul>

<h4>Como usar</h4>
 <h5>Instalar/Configurar Banco de dados </h5>
 <ul>
 <li>alterar local de instalação padrão </li>
 <li>copiar pasta bin dentro do novo local</li>
 <li>criar pasta data/db na raiz do Windows</li>
 <li>alterar variáveis de ambiente Path com o caminho até o bin<\li>
 <li>executar comando mongo no terminal </li>
 <li>executar comando "use BookstoreDb"</li>
 <li>executar comando "db.createCollection('Books')"</li>
 <li>executar comando "db.Books.insertMany([{'Name':'A Lei do triunfo','Price':60.93,'Category':'Autoestima','Author':'Napoleon Hill'}, {'Name':'Clean Code','Price':43.15,'Category':'Computers','Author':'Robert C. Martin'}])"</li>
 <li>db.Books.find({}).pretty()</li>
</ul> 
  
 <h5>Executar </h5>
 <ul> 
   <li>executar os comandos no diretório BooksApi</li>
  <li>dotnet restore </li>
  <li>dotnet watch run </li> 
  <li>acessar no navegador ou Postman http://localhost:5000 </li> 
 </ul>
 <h5>Frontend (ProAgil-App)</h5>
 <ul>
  <li>executar os comandos no diretório ProAgil-App</li>
  <li>npm install </li>
  <li>npm build  </li> 
  <li>Instalar CLI Angular (https://cli.angular.io/quickstart): npm install -g @angular/cli</li>
  <li>ng serve -o</li> 
  <li>acessar no navegador localhost:4200 </li> 
 </ul>
 
 <h5>Tela Eventos</h5>
<p><a target="_blank" rel="noopener noreferrer" href="https://user-images.githubusercontent.com/22710963/61652208-d414a600-ac8d-11e9-8f80-c8487e7fce3a.png">
<img src="https://user-images.githubusercontent.com/22710963/61652208-d414a600-ac8d-11e9-8f80-c8487e7fce3a.png" alt="reset" style="max-width:100%;"></a></p> 
 
 <h5>Login</h5>
 <p><a target="_blank" rel="noopener noreferrer" href="https://user-images.githubusercontent.com/22710963/61652753-14285880-ac8f-11e9-8806-b56b95f5fdd3.png">
 <img src="https://user-images.githubusercontent.com/22710963/61652753-14285880-ac8f-11e9-8806-b56b95f5fdd3.png" alt="reset" style="max-width:100%;"></a></p> 
  
 <h5>Editar Evento</h5>
 <p><a target="_blank" rel="noopener noreferrer" href="https://user-images.githubusercontent.com/22710963/61652913-6c5f5a80-ac8f-11e9-9073-73fe8a1acd58.png">
 <img src="https://user-images.githubusercontent.com/22710963/61652913-6c5f5a80-ac8f-11e9-9073-73fe8a1acd58.png" alt="reset" style="max-width:100%;"></a></p> 
 
