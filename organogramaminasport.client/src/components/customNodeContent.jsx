import React from "react";
import { FaBuilding } from "react-icons/fa";
import "./styles/customNodeContent.css"; 

const CustomNodeContent = (props) => {
    return (
        <>
            <div className="node-container">
                <div className="node-details">
                    {props.data.team === "" ? (
                        <div className="node-content">
                            <img
                                className="node-img"
                                src={props.data.imageUrl}
                                alt="Profile"
                            />
                            <div className="node-info">
                                <div className="node-name">{props.data.name}</div>
                                <div className="node-role">{props.data.positionName}</div>
                                {props.data.department && (
                                    <div className="node-department">
                                        <FaBuilding className="icon" />
                                        <div>{props.data.department}</div>
                                    </div>
                                )}
                            </div>
                        </div>
                    ) : (
                        <div className="node-team">
                            <div className="node-team-name">{props.data.team}</div>
                            {(props._children !== null && props._children !== undefined) &&
                                props._children
                                    .slice(0, 4)
                                    .map((child) => (
                                        child.data.imageUrl ?
                                        <img
                                            key={child.data.id}
                                            className="node-team-member-img"
                                            src={child.data.imageUrl}
                                            alt="team member"
                                        /> : null
                                    ))}
                        </div>
                    )}
                </div>
            </div>
        </>
    );
};

export default CustomNodeContent;
