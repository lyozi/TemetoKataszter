import { Box, Image } from '@chakra-ui/react';
import { useNavigate} from "react-router-dom";

interface GraveYardCardProps {
  settlement: string;
  graveyardName: string;
  image: string;
}

const GraveYardCard: React.FC<GraveYardCardProps> = ({ settlement, graveyardName, image }) => {
  const navigate = useNavigate();
  const nrOfGraves = 4;
  const area = 3450;

  return (
    <Box mt='50px' ml='80px' w="200px" borderWidth='2px' borderRadius='lg' overflow='hidden' borderColor='gray.800' onClick={() => navigate("/harta")} _hover={{ cursor: 'pointer' }} bg='gray.300'>
      <Image src={image} boxSize='200px' />

      <Box p='4'>

        <Box
          fontWeight='semibold'
          as='h4'
          lineHeight='tight'
        >
          {settlement}{graveyardName && `, ${graveyardName}`}
        </Box>


        <Box
          color='gray.500'
          fontWeight='semibold'
          fontSize='sm'
        >
          {nrOfGraves} Sírhely &bull; {area} m<sup>2</sup>
        </Box>


      </Box>
    </Box>
  );
};

export default GraveYardCard;
