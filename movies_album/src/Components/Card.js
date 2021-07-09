import React, {Component} from 'react';
import PropTypes from 'prop-types';

class Card extends Component {
  render() {


    const {title, overview, vote_avarage, poster_path}= this.props.movie

    return (
      <div className="card shadow-sm">

        <img src={`https://image.tmdb.org/t/p/w500/${poster_path}`} alt={this.props.movie.title}/>
        <div className="card-body">
          <h5 className="card-title">{title}</h5>
          <p className="card-text">{overview}</p>
          <div className="d-flex justify-content-between align-items-center">
            <div className="btn-group">
              <button type="button" className="btn btn-sm btn-outline-secondary">View</button>
            </div>
            <small className="text-muted">{vote_avarage}</small>
          </div>
        </div>
      </div>

    )
  }
}

export default Card;
