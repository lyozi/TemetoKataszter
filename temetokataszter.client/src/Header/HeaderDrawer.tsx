import { Drawer, DrawerOverlay, DrawerContent, DrawerCloseButton, DrawerHeader, DrawerBody, Flex } from '@chakra-ui/react';
import NavButtons from './NavButtons';
import React from 'react';

interface HeaderDrawerProps {
  isOpen: boolean;
  onClose: () => void;
}

const HeaderDrawer: React.FC<HeaderDrawerProps> = ({ isOpen, onClose}) => {
  return (
    <Drawer isOpen={isOpen} placement="right" onClose={onClose}>
      <DrawerOverlay />
      <DrawerContent bg="gray.800" color="white">
        <DrawerCloseButton />
        <DrawerHeader>Menü</DrawerHeader>
        <DrawerBody>
          <Flex direction={{ base: 'column', md: 'row' }}>
            <NavButtons onClose={onClose}/>
          </Flex>
        </DrawerBody>
      </DrawerContent>
    </Drawer>
  );
};

export default HeaderDrawer;
