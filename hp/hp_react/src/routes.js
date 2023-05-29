import { BrowserRouter, Route, Routes } from "react-router-dom";

import CrudPersonagens from "./components/CrudPersonagens/CrudPersonagens";

export default function Rotas() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<a href="/crud">Ir para CRUD</a>} />

        <Route path="/crud" element={<CrudPersonagens />} />
      </Routes>
    </BrowserRouter>
  );
}
