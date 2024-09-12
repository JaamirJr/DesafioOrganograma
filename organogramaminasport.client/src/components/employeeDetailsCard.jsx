import React from 'react';
import { MdClose } from "react-icons/md";
import "./styles/employeeDetailsCard.css";

const EmployeeDetailsCard = (props) => {

    if (!props.employee) {
        return <div>Carregando...</div>;
    }

    return (
        <div className="card">
            <MdClose className="card-close-btn" onClick={props.handleClose} />
            {props.employee.team ? (
                <div>
                    <div className="card-header">
                        <h2>Setor {props.employee.team}</h2>
                    </div>
                    <h4>Membros:</h4>
                    <div className="card-body-team-members">
                        {props.employees
                            .filter(
                                (employee) => employee.parentId === props.employee.id.toString()
                            )
                            .map((employee) => (
                                <div className="card-item-team" key={employee.id}>
                                    <img
                                        className="card-item-img"
                                        src={employee.imageUrl}
                                        alt="Profile"
                                    />
                                    <p className="card-item-name">{employee.name}</p>
                                    <p className="card-item-role">{employee.positionName}</p>
                                </div>
                            ))}
                    </div>
                </div>
            ) : (
                <div>
                    <div className="card-header">
                        <img
                            className="card-img"
                            src={props.employee.imageUrl}
                            alt="Profile"
                        />
                        <h2 className="card-name">{props.employee.name}</h2>
                        <p className="card-role">{props.employee.positionName}</p>
                    </div>
                    <div className="card-body">
                        <div className="card-item">
                            <p className="card-item-label">Contato:</p>
                            <p className="card-item-value">{props.employee.phone}</p>
                        </div>
                        <div className="card-item">
                            <p className="card-item-label">Email:</p>
                            <p className="card-item-value">{props.employee.email}</p>
                        </div>
                        <div className="card-item">
                            <p className="card-item-label">Localização:</p>
                            <p className="card-item-value">{props.employee.location}</p>
                        </div>
                        {props.employee.department && (
                            <div className="card-item">
                                <p className="card-item-label">Departamento:</p>
                                <p className="card-item-value">{props.employee.department}</p>
                            </div>
                        )}
                    </div>
                </div>
            )}
            <div className="card-item">
                <p className="card-item-label">Descrição do cargo:</p>
                <p className="card-item-value">{props.employee.description}</p>
            </div>
        </div>
    );
};

export default EmployeeDetailsCard;
