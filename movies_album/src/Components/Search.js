import React, { Component } from "react";

class Search extends Component{

  state ={
    term: " "
  }
  handleOnSubmit = (event) =>{
    event.preventDefault()
    this.props.searchMovie(this.state.term)
  }
  handleOnSearch =(event) => {
    this.setState({term : event.target.value})
  }

  render() {
    return(
      <form onSubmit={this.handleOnSubmit} className="row g-3 mb-5">
        <div className="col-8">
          <input onChange={this.handleOnSearch} type="text" className="form-control" value={this.state.term} placeholder="Search.."/>
        </div>
        <div className="col-4">
          <input type="submit" value="Search" className="form-control btn-block btn btn-danger text-white"/>
        </div>
      </form>
    )
  }
}

export default Search