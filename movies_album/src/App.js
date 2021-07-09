import React, {Component} from "react";
import Navbar from './Components/Navbar';
import Header from './Components/Header';
import Search from "./Components/Search";
import CardList from "./Components/CardList";
import Footer from "./Components/Footer";
import {logDOM} from "@testing-library/react";

class App extends React.Component {

  constructor() {
    super();
    this.state = {
      movies: [],

      loading: false
    }
  }

  componentDidMount() {
    this.setState({loading: true})
    fetch('https://api.themoviedb.org/3/movie/popular?api_key=49ab29ee9150d894f60ff78eed46e7fc')
      .then(response => response.json())
      .then(data => this.setState({movies : data.results, loading: false}))
  }

  searchMovie = (term) => {
    fetch(`https://api.themoviedb.org/3/search/movie?api_key=49ab29ee9150d894f60ff78eed46e7fc&query=${term}`)
      .then(response => response.json())
      .then(data => this.setState({movies: data.results}))
  }

  render() {
    return (
      <>
        <Navbar/>
        <main>
          <Header title="Movies Album" slogan="Sample slogan text"/>
          <div className="album py-5 bg-light">
            <div className="container">
              <Search searchMovie={this.searchMovie}/>
              {
                this.state.loading ?
                  (
                    <div className="spinner-border text-danger" role="status">
                      <span className="visually-hidden">Loading...</span>
                    </div>
                  )
                  :
                  <CardList movies={this.state.movies}/>
              }
            </div>
          </div>
        </main>

        <Footer/>
      </>
    );
  }
}

export default App;
