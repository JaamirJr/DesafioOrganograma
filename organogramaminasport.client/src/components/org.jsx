import React, { useEffect, useState } from 'react';
import OrganizationalChart from "./orgChart";
import "./styles/org.css";

const Org = () => {
    const [employees, setEmployees] = useState(null);
    const [loading, setLoading] = useState(true);
    const [retryCount, setRetryCount] = useState(0);
    const [selectedOption, setSelectedOption] = useState('hibrido');

    const fetchData = async (option = 'hibrido') => {
        try {
            setLoading(true);
            const response = await fetch(`organograma\\${option}`);
            if (response.status === 200) {
                const data = await response.json();
                setEmployees(data);
                setLoading(false);
            } else {
                throw new Error('Erro ao buscar dados');
            }
        } catch (error) {
            console.log(error.message);
            setLoading(false);
            setRetryCount(prevRetryCount => prevRetryCount + 1);
        }
    };

    useEffect(() => {
        const tryFetchData = () => {
            if (!employees && retryCount < 5) {
                fetchData(selectedOption);
            }
        };

        if (!employees) {
            fetchData(selectedOption);
            const interval = setInterval(tryFetchData, 10000);

            return () => clearInterval(interval);
        }
    }, [retryCount, employees, selectedOption]);

    const handleOptionChange = (e) => {
        setSelectedOption(e.target.value);
        fetchData(e.target.value);
    };

    if (loading) {
        return <p className="loading-message">Carregando...</p>;
    }

    if (!employees) {
        return <p className="error-message">Algo deu errado ao carregar os dados. Tentando novamente...</p>;
    }

    return (
        <>
            <div className="header-container">
                <select className="org-select" value={selectedOption} onChange={handleOptionChange}>
                    <option value="hibrido">Padronizado</option>
                    <option value="setorial">Setorial</option>
                </select>
                <h1 className="title">Organograma Minas Port</h1>
            </div>
            <OrganizationalChart data={employees} />
        </>
    );
};

export default Org;
