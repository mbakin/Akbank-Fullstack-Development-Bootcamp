import React, { useEffect, useState} from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Navbar from './Components/Navbar';
import Header from './Components/Header';
import Search from "./Components/Search";
import CardList from "./Components/CardList";
import Footer from "./Components/Footer";
import About from "./Components/About";
import CardDetail from "./Components/CardDetail";

const App = () =>  {

  const [movies, setMovies] = useState([])
  const [loading, setLoading] = useState(false)

   useEffect(()=>{
     getMovies()
   }, [])

  const getMovies = () => {
    //this.setState({loading: true})
    setLoading(true)
    fetch('https://api.themoviedb.org/3/movie/popular?api_key=49ab29ee9150d894f60ff78eed46e7fc')
      .then(response => response.json())
      .then(data => {
        //this.setState({movies : data.results, loading: false}))
        setMovies(data.results)
        setLoading(false)
      }
      )
    }
  

  const searchMovie = (term) => {
    fetch(`https://api.themoviedb.org/3/search/movie?api_key=49ab29ee9150d894f60ff78eed46e7fc&query=${term}`)
      .then(response => response.json())
      .then(data => setMovies( data.results))
  }

  
    return (
      <Router>
   
        <Navbar/>
        <Switch>
          <Route exact path="/">
            <main>
              <Header title="Movies Album" slogan="Sample slogan text"/>
              <div className="album py-5 bg-light">
                <div className="container">
                  <Search searchMovie={searchMovie}/>
                  {
                    loading ?
                      (
                        <div className="spinner-border text-danger" role="status">
                          <span className="visually-hidden">Loading...</span>
                        </div>
                      )
                      :
                      <CardList movies={movies}/>
                  }
                </div>
              </div>
            </main>
          </Route>
        
        <Route path="/about" component={About} />
        <Route path="/movies/:id" component={CardDetail} />
        
        </Switch>
        <Footer/>
      </Router>
      
    );
  }

export default App;
