// ./clientside/zig-movie-app/src/components/MovieDetailPage.tsx

import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';

const MovieDetailPage: React.FC = () => {
  const { movieId } = useParams<{ movieId: string }>();
  const [movie, setMovie] = useState<any>({});

  useEffect(() => {
    fetch(`/api/movie/${movieId}`)
      .then((response) => response.json())
      .then((data) => setMovie(data));
  }, [movieId]);

  return (
    <div>
      <h2>{movie.title}</h2>
      <img src={movie.posterUrl} alt={movie.title} />
      <p>{movie.description}</p>
      <a href={movie.officialSite} target="_blank" rel="noopener noreferrer">
        Official Site
      </a>
    </div>
  );
};

export default MovieDetailPage;
