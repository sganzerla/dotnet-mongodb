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
 <li>executar comando "db.Books.insertMany([{'Name':'A Lei do triunfo','Price':60.93,'Category':'Motivacional','Author':'Napoleon Hill'}, {'Name':'Clean Code','Price':43.15,'Category':'Computers','Author':'Robert C. Martin'}])"</li>
 <li>executar db.Books.find({}).pretty()</li>
</ul> 
  
 <h5>Executar </h5>
 <ul> 
   <li>executar os comandos no diretório BooksApi</li>
  <li>dotnet restore </li>
  <li>dotnet watch run </li> 
  <li>acessar no navegador ou Postman http://localhost:5000 </li> 
 </ul>
 
<h5>Tela Inicial Swagger</h5>
<p><a target="_blank" rel="noopener noreferrer" href=" https://user-images.githubusercontent.com/22710963/61924934-5c21d680-af40-11e9-9b79-ff7135abc568.png">
<img src="https://user-images.githubusercontent.com/22710963/61924934-5c21d680-af40-11e9-9b79-ff7135abc568.png" alt="reset" style="max-width:100%;"></a></p> 

<h5>Consulta via tela Swagger</h5>
<p><a target="_blank" rel="noopener noreferrer" href="https://user-images.githubusercontent.com/22710963/61924705-5d9ecf00-af3f-11e9-8188-e62dd1c35ce4.png">
<img src="https://user-images.githubusercontent.com/22710963/61924705-5d9ecf00-af3f-11e9-8188-e62dd1c35ce4.png" alt="reset" style="max-width:100%;"></a></p> 
 
 <h5>Consulta via Compass</h5>
 <p><a target="_blank" rel="noopener noreferrer" href="https://user-images.githubusercontent.com/22710963/61924828-e74e9c80-af3f-11e9-8427-99a08c479067.png">
 <img src="https://user-images.githubusercontent.com/22710963/61924828-e74e9c80-af3f-11e9-8427-99a08c479067.png" alt="reset" style="max-width:100%;"></a></p> 
  
 
