import React from "react";
import { FaAngleDown, FaAngleUp } from "react-icons/fa";
import "./styles/customExpandButton.css";

const CustomExpandButton = (node) => {
    return (
        <>
            {node && (
                <div className="expand-btn">
                    <span>{node.data._directSubordinates}</span>
                    <span className="flex">
                        {node.children ? <FaAngleUp /> : <FaAngleDown />}
                    </span>
                </div>
            )}
        </>
    );
};

export default CustomExpandButton;
