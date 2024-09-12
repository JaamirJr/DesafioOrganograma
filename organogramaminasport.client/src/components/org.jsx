import React, { useEffect, useState } from 'react';
import OrganizationalChart from "./orgChart";
import "./styles/org.css";

const Org = () => {
    const [employees, setEmployees] = useState(null);
    const [loading, setLoading] = useState(true);
    const [retryCount, setRetryCount] = useState(0);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch('organograma');
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

        const tryFetchData = () => {
            if (retryCount < 5) {
                fetchData();
            } else {
                console.log('Número máximo de tentativas alcançado');
            }
        };

        fetchData();
        const interval = setInterval(tryFetchData, 10000);

        return () => clearInterval(interval);
    }, [retryCount]);

    if (loading) {
        return <p className="loading-message">Carregando...</p>;
    }

    if (!employees) {
        return <p className="error-message">Algo deu errado ao carregar os dados. Tentando novamente...</p>;
    }

    return (
        <>
            <h1 className="title">Organograma Minas Port</h1>
            <OrganizationalChart data={employees} />
        </>
    );
};

export default Org;
