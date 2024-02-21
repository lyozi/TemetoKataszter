import { Box, Image } from '@chakra-ui/react';
import GraveYardCard from './GraveYardCard';
import balyok from '../Pictures/balyok.png';


const Home = () => {
  const nrOfGraves = 4;
  const area = 3450;

  return (
    <GraveYardCard settlement="Bályok" graveyardName="" image={balyok} />
  );
};

export default Home;
