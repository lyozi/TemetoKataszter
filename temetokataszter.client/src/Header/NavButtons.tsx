import React from 'react';
import { Button } from '@chakra-ui/react';
import { useNavigate, useLocation } from "react-router-dom";

interface NavButtonsProps {
  onClose: () => void;
}

const buttonStyles = {
  color: "gray.200",
  fontSize: "30px",
  size: "lg",
  height: '45px',
  mr: '10px',
  variant: "ghost",
  _hover: { bg: 'gray.600', color: "white" },
  _active: { bg: 'gray.600' }
};

const NavButtons: React.FC<NavButtonsProps> = ({ onClose }) => {
  const navigate = useNavigate();
  const location = useLocation();

  const handleClick = (url: string) => {
    navigate(url);
    onClose();
  }

  return (
    <>
      <Button
        {...buttonStyles}
        onClick={() => handleClick("/lista_inmormantati")}
        isActive={location.pathname === "/lista_inmormantati"}
      >
        Elhunytak
      </Button>
      <Button
        {...buttonStyles}
        onClick={() => handleClick("/harta")}
        isActive={location.pathname === "/harta"}
      >
        Térkép
      </Button>
      <Button
        {...buttonStyles}
        onClick={() => handleClick("/")}
        isActive={location.pathname === "/"}
      >
        Temetők
      </Button>
      <Button
        {...buttonStyles}
        onClick={() => handleClick("/informatii")}
        isActive={location.pathname === "/informatii"}
      >
        Információ
      </Button>
      <Button
        {...buttonStyles}
        onClick={() => handleClick("/login-register")}
        isActive={location.pathname === "/login-register"}
      >
        Bejelentkezés
      </Button>
    </>
  );
};

export default NavButtons;
