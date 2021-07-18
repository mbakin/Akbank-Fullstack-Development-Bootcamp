import React, {Component} from "react";
import Card from "./Card";


const CardList = (props) => {
  
    return (
      <div className="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3">

        {
          props.movies.map(function (movie){
            return(
              <div className="col" key={movie.id}>
                <Card movie={movie}/>
              </div>
            )
          })
        }

      </div>
    );
  
}

export default CardList