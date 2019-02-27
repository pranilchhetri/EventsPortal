const express = require('express');
const path = require('path');
const mongoose= require('mongoose');
const bodyParser=require('body-parser');

mongoose.connect('mongodb://localhost/mydb');
let db= mongoose.connection;

db.once('open',function(){
    console.log('connected to mongodb');
})

//Check for DB erros
db.on('error',function(err){
console.log(err);
});

//Init App
const app = express();

//Bring in Models
let Article = require('./models/article');

//Load View Engine
app.set('views',path.join(__dirname,'views'));
app.set('view engine','pug');

//Body Parser Middleware
//parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({extended:false}));
//parse application/json
app.use(bodyParser.json());




//Home Route
app.get('/',function(req,res){

    Article.find({},function(err,articles){
        if(err){
            console.log(err);
        }else{
        
        res.render('index',{
            title:'Articles',
            articles:articles
    });
        }
    });
    // let articles=[
    //     {
    //         id:1,
    //         title:"Article One",
    //         author:'Pranil GC',
    //         body:'This is my first article'
    //     },
    //     {
    //         id:2,
    //         title:"Article Two",
    //         author:'Pranil GC',
    //         body:'This is my second article'
    //     },
    //     {
    //         id:3,
    //         title:"Article Three",
    //         author:'Pranil GC',
    //         body:'This is my third article'
    //     },
    // ]

    
});


//Add Route
app.get('/articles/add',function(req,res){
    res.render('add_article',{
        title:'Add Article'
    })
})

//Add Submit POST Route
app.post('/articles/add',function(req,res){
    let article=new Article();
    article.title=req.body.title;
    article.author=req.body.author;

    article.body=req.body.body;
    article.save(function(err){
        if(err){
            console.log(err);
            return;
        }else{
            res.redirect('/');
        }
    })
});


app.listen(3000,function(){
    console.log('Server started on port 3000');

});