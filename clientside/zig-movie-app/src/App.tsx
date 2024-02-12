// ./clientside/zig-movie-app/src/App.tsx

import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './components/HomePage';
import SearchBar from './components/SearchBar';
import MovieDetailPage from './components/MovieDetailPage';

const App: React.FC = () => {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/search" element={<SearchBar onSearch={() => {}} />} />
        <Route path="/movie/:movieId" element={<MovieDetailPage />} />
      </Routes>
    </Router>
  );
};

export default App;
