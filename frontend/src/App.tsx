import React, {useEffect, useState} from 'react';
import {Element} from "./components/Element";
import {useList} from "./hooks/list";
import {Modal} from "./components/Modal";
import {AddList} from "./components/AddList";

function App() {
    const list = useList();

    return (
        <div className="container mx-auto mx-w-2xl pt-5">
            {list.map(el => <Element element={el} key={el.number}/>)}

            <Modal>
                <AddList/>
            </Modal>
        </div>);
}

export default App;
