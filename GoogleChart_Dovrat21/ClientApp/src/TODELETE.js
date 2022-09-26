import React from "react";
import { useNotesStore } from "./JobsContext";
import { useObserver } from "mobx-react";

export const NewNoteForm = () => {

    const [noteText, setNoteText] = React.useState("");
    const notesStore = useNotesStore();

    return useObserver(() => (
        <>
            <ul>
                {notesStore.outputData.map((note) => (
                    <li>{note}</li>
                ))}
            </ul>
            <input
                value={noteText}
                onChange={(e) => setNoteText(e.target.value)}
                type="text"
            />
            <button onClick={() => notesStore.addNote(noteText)}>Add note</button>
        </>
    ));
};