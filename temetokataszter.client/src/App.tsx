import { ChakraProvider, extendTheme } from '@chakra-ui/react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Header from './Header/Header';
import Map from './GraveyardMap/Map';
import Information from './Information/Information';
import NotFound from './NotFound/NotFound';
import Home from './Home/Home';
import GraveList from './GraveList/GraveList';

const theme = extendTheme({
  styles: {
    global: {
      body: {
        bg: 'gray.200',
      },
    },
  },
});

function App() {
  return (
    <ChakraProvider theme={theme}>
      <Router>
        <Header />
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/harta" element={<Map />} />
          <Route path="/informatii" element={<Information />} />
          <Route path="lista_inmormantati" element={<GraveList />}></Route>
          <Route path="*" element={<NotFound />} />
        </Routes>


      </Router>
    </ChakraProvider>
  );
}

export default App;
