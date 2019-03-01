const express = require('express');
const path = require('path');
const mongoose= require('mongoose');
const bodyParser=require('body-parser');
const cors=require('cors');

const db=require('./config/db').database;


//Init App
const app = express();

//database connection
mongoose.connect(db, {useNewUrlParser:true})
    .then(()=>{
        console.log('Database Connected Successfully')

    })
    .catch((err)=>{
        console.log('Unable to connect with the database',err)
    });

//Defining the PORT
const port =process.env.PORT || 3000;  

// Initialize cors Middleware
app.use(cors());

//Body Parser Middleware
//parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({extended:false}));
//parse application/json
app.use(bodyParser.json());

//Initialize Public Directory
app.get('*',function(req,res){
    res.sendFile(path.join(__dirname,'public/index.html'));
});


//Home Route
app.get('/',function(req,res){

    res.send('Hello World!');
 
    });
   



app.listen(port,function(){
    console.log('Server started on port',port);

});




// //Bring in Models
// let Article = require('./models/article');

// //Load View Engine
// app.set('views',path.join(__dirname,'views'));
// app.set('view engine','pug');


// // Set Public Folder
// app.use(express.static(path.join(__dirname, 'public')));





// //Add Route
// app.get('/articles/add',function(req,res){
//     res.render('add_article',{
//         title:'Add Article'
//     })
// })

// //Add Submit POST Route
// app.post('/articles/add',function(req,res){
//     let article=new Article();
//     article.title=req.body.title;
//     article.author=req.body.author;

//     article.body=req.body.body;
//     article.save(function(err){
//         if(err){
//             console.log(err);
//             return;
//         }else{
//             res.redirect('/');
//         }
//     })
// });


