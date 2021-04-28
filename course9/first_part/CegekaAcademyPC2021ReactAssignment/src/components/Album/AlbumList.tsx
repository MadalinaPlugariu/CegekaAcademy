import Album, { AlbumForm } from '../Album';
import { Card, Button, Icon } from 'semantic-ui-react';
// import StatusBar from '../StatusBar';
import { WithLightbox, DeleteButton } from '../Common';
import { PhotoModel } from '../../models/PhotoModel';
import { AlbumModel } from '../../models/AlbumModel';

interface AlbumListProps {
    albums: AlbumModel[];
    photos: PhotoModel[];
    deleteAlbum: (index: string) => void;
    editAlbum: Function;
    createAlbum: Function;
}

const AlbumList = ({albums, photos, deleteAlbum, editAlbum, createAlbum} : AlbumListProps) =>{
    const getAlbumPhotos = (album: AlbumModel) =>{
        return photos
         .filter(photo => album.photosIds.includes(photo.id));
    }

    const renderAlbums = () => {
        return (
            albums
             .map(album => {
                 const albumPhotos = getAlbumPhotos(album);

                 return(
                     <Album 
                        key={album.id}
                        album={album}
                        albumPhotos={albumPhotos}
                     >
                        <Button icon>
                            <WithLightbox  photos={albumPhotos}>
                                <Icon name='play' />
                            </WithLightbox>
                        </Button>
                        <AlbumForm
                            formType='Edit'
                            index={album.id}
                            albumProp={album}
                            photos={photos}
                            editAlbum={editAlbum}
                            createAlbum={createAlbum}
                        />
                        <DeleteButton 
                            index={album.id}
                            objectName={album.name}
                            deleteObject={deleteAlbum}
                        />
                     </Album>
                 );
             })
        );
    }
    return (
        <div>
            <Card.Group >
             {renderAlbums()}
           </Card.Group>
        </div>
       
    )
}

export default AlbumList;